// DebugValueTooltipProvider.cs
//
// Author:
//   Lluis Sanchez Gual <lluis@novell.com>
//
// Copyright (c) 2008 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using System.Collections.Generic;
using Mono.TextEditor;
using MonoDevelop.Ide.Gui;
using Mono.Debugging.Client;
using TextEditor = Mono.TextEditor.TextEditor;
using MonoDevelop.Projects.Dom;
using MonoDevelop.Projects.Dom.Parser;
using MonoDevelop.Ide.CodeCompletion;
using MonoDevelop.Debugger;

namespace MonoDevelop.SourceEditor
{
	public class DebugValueTooltipProvider: ITooltipProvider
	{
		Dictionary<string,ObjectValue> cachedValues = new Dictionary<string,ObjectValue> ();
		
		public DebugValueTooltipProvider()
		{
			DebuggingService.CurrentFrameChanged += delegate {
				// Clear the cached values every time the current frame changes
				cachedValues.Clear ();
			};
		}

		#region ITooltipProvider implementation 
		
		public TooltipItem GetItem (Mono.TextEditor.TextEditor editor, int offset)
		{
			if (offset >= editor.Document.Length)
				return null;
			
			if (!DebuggingService.IsDebugging || DebuggingService.IsRunning)
				return null;
				
			StackFrame frame = DebuggingService.CurrentFrame;
			if (frame == null)
				return null;
			
			ExtensibleTextEditor ed = (ExtensibleTextEditor) editor;
			
			string expression = null;
			int startOffset = 0, length = 0;
			if (ed.IsSomethingSelected && offset >= ed.SelectionRange.Offset && offset <= ed.SelectionRange.EndOffset) {
				expression = ed.SelectedText;
				startOffset = ed.SelectionRange.Offset;
				length = ed.SelectionRange.Length;
			} else {
				ResolveResult res = ed.GetLanguageItem (offset);
/*				if (res is MemberResolveResult) {
					MemberResolveResult mr = (MemberResolveResult) res;
					if (mr.ResolvedMember == null && mr.ResolvedType != null)
						expression = mr.ResolvedType.FullName;
				}
				if (expression == null)*/
				if (res != null && res.ResolvedExpression != null) {
					expression = res.ResolvedExpression.Expression;
					startOffset = editor.Document.LocationToOffset (res.ResolvedExpression.Region.Start.Line - 1, res.ResolvedExpression.Region.Start.Column - 1);
					int endOffset = editor.Document.LocationToOffset (res.ResolvedExpression.Region.End.Line - 1, res.ResolvedExpression.Region.End.Column - 1);
					length = endOffset - startOffset;
				}
			}
			
			if (string.IsNullOrEmpty (expression))
				return null;
			
			ObjectValue val;
			if (!cachedValues.TryGetValue (expression, out val)) {
				val = frame.GetExpressionValue (expression, false);
				cachedValues [expression] = val;
			}
			if (val == null || val.IsUnknown || val.IsNotSupported)
				return null;
			return new TooltipItem (val, startOffset, length);
		}
		
		/*string GetExpressionBeforeOffset (TextEditor editor, int offset)
		{
			int start = offset;
			while (start > 0 && IsIdChar (editor.Document.GetCharAt (start)))
				start--;
			while (offset < editor.Document.Length && IsIdChar (editor.Document.GetCharAt (offset)))
				offset++;
			start++;
			if (offset - start > 0 && start < editor.Document.Length)
				return editor.Document.GetTextAt (start, offset - start);
			else
				return string.Empty;
		}*/
		
		public static bool IsIdChar (char c)
		{
			return char.IsLetterOrDigit (c) || c == '_';
		}
			
		public Gtk.Window CreateTooltipWindow (Mono.TextEditor.TextEditor editor, int offset, Gdk.ModifierType modifierState, TooltipItem item)
		{
			return new DebugValueWindow (editor, offset, DebuggingService.CurrentFrame, (ObjectValue) item.Item, null);
		}
		
		public void GetRequiredPosition (Mono.TextEditor.TextEditor editor, Gtk.Window tipWindow, out int requiredWidth, out double xalign)
		{
			xalign = 0.1;
			requiredWidth = tipWindow.SizeRequest ().Width;
		}

		public bool IsInteractive (Mono.TextEditor.TextEditor editor, Gtk.Window tipWindow)
		{
			return true;
		}
		
		#endregion 
		
	}
}

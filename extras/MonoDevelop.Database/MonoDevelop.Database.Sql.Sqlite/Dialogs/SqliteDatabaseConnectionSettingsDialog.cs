﻿//
// Authors:
//   Ben Motmans  <ben.motmans@gmail.com>
//
// Copyright (c) 2008 Ben Motmans
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

using Gtk;
using System;
using System.Threading;
using System.Collections.Generic;
using MonoDevelop.Core;
using MonoDevelop.Core.Gui;
using MonoDevelop.Database.Sql;
using MonoDevelop.Database.Components;
using MonoDevelop.Database.Designer;

namespace MonoDevelop.Database.Sql.Sqlite
{
	public class SqliteDatabaseConnectionSettingsDialog : DatabaseConnectionSettingsDialog
	{
		public SqliteDatabaseConnectionSettingsDialog (IDbFactory factory)
			: base (factory)
		{
		}
		
		public SqliteDatabaseConnectionSettingsDialog (IDbFactory factory, DatabaseConnectionSettings settings)
			: base (factory, settings)
		{
		}
		
		protected override ConnectionSettingsWidget CreateConnectionSettingsWidget (IDbFactory factory, bool isEditMode)
		{
			return new SqliteConnectionSettingsWidget (factory);
		}
	}
}
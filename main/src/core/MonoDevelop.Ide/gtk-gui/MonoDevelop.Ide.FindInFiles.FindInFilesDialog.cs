// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.FindInFiles {
    
    
    public partial class FindInFilesDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Table tableFindAndReplace;
        
        private Gtk.ComboBoxEntry comboboxentryFileMask;
        
        private Gtk.ComboBoxEntry comboboxentryFind;
        
        private Gtk.HBox hbox2;
        
        private Gtk.ComboBox comboboxScope;
        
        private Gtk.Label labelFileMask;
        
        private Gtk.Label labelFind;
        
        private Gtk.Label labelScope;
        
        private Gtk.Table table1;
        
        private Gtk.CheckButton checkbuttonCaseSensitive;
        
        private Gtk.CheckButton checkbuttonRegexSearch;
        
        private Gtk.CheckButton checkbuttonWholeWordsOnly;
        
        private Gtk.Button buttonStop;
        
        private Gtk.Button buttonClose;
        
        private Gtk.Button buttonReplace;
        
        private Gtk.Button buttonSearch;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.FindInFiles.FindInFilesDialog
            this.Name = "MonoDevelop.Ide.FindInFiles.FindInFilesDialog";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            this.DestroyWithParent = true;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child MonoDevelop.Ide.FindInFiles.FindInFilesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.tableFindAndReplace = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.tableFindAndReplace.Name = "tableFindAndReplace";
            this.tableFindAndReplace.RowSpacing = ((uint)(6));
            this.tableFindAndReplace.ColumnSpacing = ((uint)(6));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.comboboxentryFileMask = Gtk.ComboBoxEntry.NewText();
            this.comboboxentryFileMask.Name = "comboboxentryFileMask";
            this.tableFindAndReplace.Add(this.comboboxentryFileMask);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.comboboxentryFileMask]));
            w2.TopAttach = ((uint)(2));
            w2.BottomAttach = ((uint)(3));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.comboboxentryFind = Gtk.ComboBoxEntry.NewText();
            this.comboboxentryFind.Name = "comboboxentryFind";
            this.tableFindAndReplace.Add(this.comboboxentryFind);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.comboboxentryFind]));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.comboboxScope = Gtk.ComboBox.NewText();
            this.comboboxScope.Name = "comboboxScope";
            this.hbox2.Add(this.comboboxScope);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.comboboxScope]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            this.tableFindAndReplace.Add(this.hbox2);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.hbox2]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.labelFileMask = new Gtk.Label();
            this.labelFileMask.Name = "labelFileMask";
            this.labelFileMask.Xalign = 0F;
            this.labelFileMask.LabelProp = Mono.Unix.Catalog.GetString("_File Mask:");
            this.labelFileMask.UseUnderline = true;
            this.tableFindAndReplace.Add(this.labelFileMask);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.labelFileMask]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.labelFind = new Gtk.Label();
            this.labelFind.Name = "labelFind";
            this.labelFind.Xalign = 0F;
            this.labelFind.LabelProp = Mono.Unix.Catalog.GetString("_Find:");
            this.labelFind.UseUnderline = true;
            this.tableFindAndReplace.Add(this.labelFind);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.labelFind]));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child tableFindAndReplace.Gtk.Table+TableChild
            this.labelScope = new Gtk.Label();
            this.labelScope.Name = "labelScope";
            this.labelScope.Xalign = 0F;
            this.labelScope.LabelProp = Mono.Unix.Catalog.GetString("_Scope:");
            this.labelScope.UseUnderline = true;
            this.tableFindAndReplace.Add(this.labelScope);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.tableFindAndReplace[this.labelScope]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            this.hbox1.Add(this.tableFindAndReplace);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox1[this.tableFindAndReplace]));
            w9.Position = 0;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.checkbuttonCaseSensitive = new Gtk.CheckButton();
            this.checkbuttonCaseSensitive.CanFocus = true;
            this.checkbuttonCaseSensitive.Name = "checkbuttonCaseSensitive";
            this.checkbuttonCaseSensitive.Label = Mono.Unix.Catalog.GetString("_Case sensitive");
            this.checkbuttonCaseSensitive.DrawIndicator = true;
            this.checkbuttonCaseSensitive.UseUnderline = true;
            this.table1.Add(this.checkbuttonCaseSensitive);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.checkbuttonCaseSensitive]));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.checkbuttonRegexSearch = new Gtk.CheckButton();
            this.checkbuttonRegexSearch.CanFocus = true;
            this.checkbuttonRegexSearch.Name = "checkbuttonRegexSearch";
            this.checkbuttonRegexSearch.Label = Mono.Unix.Catalog.GetString("Rege_x search");
            this.checkbuttonRegexSearch.DrawIndicator = true;
            this.checkbuttonRegexSearch.UseUnderline = true;
            this.table1.Add(this.checkbuttonRegexSearch);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.checkbuttonRegexSearch]));
            w12.TopAttach = ((uint)(2));
            w12.BottomAttach = ((uint)(3));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.checkbuttonWholeWordsOnly = new Gtk.CheckButton();
            this.checkbuttonWholeWordsOnly.CanFocus = true;
            this.checkbuttonWholeWordsOnly.Name = "checkbuttonWholeWordsOnly";
            this.checkbuttonWholeWordsOnly.Label = Mono.Unix.Catalog.GetString("_Whole words only");
            this.checkbuttonWholeWordsOnly.DrawIndicator = true;
            this.checkbuttonWholeWordsOnly.UseUnderline = true;
            this.table1.Add(this.checkbuttonWholeWordsOnly);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.checkbuttonWholeWordsOnly]));
            w13.TopAttach = ((uint)(1));
            w13.BottomAttach = ((uint)(2));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox2.Add(this.table1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.table1]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            // Internal child MonoDevelop.Ide.FindInFiles.FindInFilesDialog.ActionArea
            Gtk.HButtonBox w16 = this.ActionArea;
            w16.Name = "dialog1_ActionArea";
            w16.Spacing = 6;
            w16.BorderWidth = ((uint)(5));
            w16.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonStop = new Gtk.Button();
            this.buttonStop.CanFocus = true;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseStock = true;
            this.buttonStop.UseUnderline = true;
            this.buttonStop.Label = "gtk-stop";
            this.AddActionWidget(this.buttonStop, 0);
            Gtk.ButtonBox.ButtonBoxChild w17 = ((Gtk.ButtonBox.ButtonBoxChild)(w16[this.buttonStop]));
            w17.Expand = false;
            w17.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonClose = new Gtk.Button();
            this.buttonClose.CanDefault = true;
            this.buttonClose.CanFocus = true;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseStock = true;
            this.buttonClose.UseUnderline = true;
            this.buttonClose.Label = "gtk-close";
            this.AddActionWidget(this.buttonClose, -7);
            Gtk.ButtonBox.ButtonBoxChild w18 = ((Gtk.ButtonBox.ButtonBoxChild)(w16[this.buttonClose]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonReplace = new Gtk.Button();
            this.buttonReplace.CanFocus = true;
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.UseUnderline = true;
            // Container child buttonReplace.Gtk.Container+ContainerChild
            Gtk.Alignment w19 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w20 = new Gtk.HBox();
            w20.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w21 = new Gtk.Image();
            w21.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-find-and-replace", Gtk.IconSize.Menu, 16);
            w20.Add(w21);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w23 = new Gtk.Label();
            w23.LabelProp = Mono.Unix.Catalog.GetString("R_eplace");
            w23.UseUnderline = true;
            w20.Add(w23);
            w19.Add(w20);
            this.buttonReplace.Add(w19);
            this.AddActionWidget(this.buttonReplace, 0);
            Gtk.ButtonBox.ButtonBoxChild w27 = ((Gtk.ButtonBox.ButtonBoxChild)(w16[this.buttonReplace]));
            w27.Position = 2;
            w27.Expand = false;
            w27.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonSearch = new Gtk.Button();
            this.buttonSearch.CanDefault = true;
            this.buttonSearch.CanFocus = true;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.UseStock = true;
            this.buttonSearch.UseUnderline = true;
            this.buttonSearch.Label = "gtk-find";
            this.AddActionWidget(this.buttonSearch, 0);
            Gtk.ButtonBox.ButtonBoxChild w28 = ((Gtk.ButtonBox.ButtonBoxChild)(w16[this.buttonSearch]));
            w28.Position = 3;
            w28.Expand = false;
            w28.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 456;
            this.DefaultHeight = 288;
            this.labelFileMask.MnemonicWidget = this.comboboxentryFileMask;
            this.labelFind.MnemonicWidget = this.comboboxentryFind;
            this.labelScope.MnemonicWidget = this.comboboxScope;
            this.Show();
        }
    }
}
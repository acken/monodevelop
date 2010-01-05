// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.OptionPanels {
    
    
    internal partial class BuildPanelWidget {
        
        private Gtk.VBox vbox66;
        
        private Gtk.CheckButton buildBeforeRunCheckBox;
        
        private Gtk.CheckButton runWithWarningsCheckBox;
        
        private Gtk.CheckButton checkXBuild;
        
        private Gtk.Label buildAndRunOptionsLabel;
        
        private Gtk.HBox hbox44;
        
        private Gtk.Label label71;
        
        private Gtk.VBox vbox67;
        
        private Gtk.RadioButton saveChangesRadioButton;
        
        private Gtk.RadioButton promptChangesRadioButton;
        
        private Gtk.RadioButton noSaveRadioButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget";
            // Container child MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget.Gtk.Container+ContainerChild
            this.vbox66 = new Gtk.VBox();
            this.vbox66.Name = "vbox66";
            this.vbox66.Spacing = 6;
            // Container child vbox66.Gtk.Box+BoxChild
            this.buildBeforeRunCheckBox = new Gtk.CheckButton();
            this.buildBeforeRunCheckBox.CanFocus = true;
            this.buildBeforeRunCheckBox.Name = "buildBeforeRunCheckBox";
            this.buildBeforeRunCheckBox.Label = Mono.Unix.Catalog.GetString("Build solution before running");
            this.buildBeforeRunCheckBox.DrawIndicator = true;
            this.buildBeforeRunCheckBox.UseUnderline = true;
            this.vbox66.Add(this.buildBeforeRunCheckBox);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox66[this.buildBeforeRunCheckBox]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox66.Gtk.Box+BoxChild
            this.runWithWarningsCheckBox = new Gtk.CheckButton();
            this.runWithWarningsCheckBox.CanFocus = true;
            this.runWithWarningsCheckBox.Name = "runWithWarningsCheckBox";
            this.runWithWarningsCheckBox.Label = Mono.Unix.Catalog.GetString("Run solution if build completed with warnings");
            this.runWithWarningsCheckBox.DrawIndicator = true;
            this.runWithWarningsCheckBox.UseUnderline = true;
            this.vbox66.Add(this.runWithWarningsCheckBox);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox66[this.runWithWarningsCheckBox]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox66.Gtk.Box+BoxChild
            this.checkXBuild = new Gtk.CheckButton();
            this.checkXBuild.CanFocus = true;
            this.checkXBuild.Name = "checkXBuild";
            this.checkXBuild.Label = Mono.Unix.Catalog.GetString("Compile projects using MSBuild / XBuild\n(this is an experimental feature and may not work for some projects)");
            this.checkXBuild.DrawIndicator = true;
            this.checkXBuild.UseUnderline = true;
            this.vbox66.Add(this.checkXBuild);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox66[this.checkXBuild]));
            w3.Position = 2;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox66.Gtk.Box+BoxChild
            this.buildAndRunOptionsLabel = new Gtk.Label();
            this.buildAndRunOptionsLabel.Name = "buildAndRunOptionsLabel";
            this.buildAndRunOptionsLabel.Xalign = 0F;
            this.buildAndRunOptionsLabel.Yalign = 0F;
            this.buildAndRunOptionsLabel.LabelProp = Mono.Unix.Catalog.GetString("<b>File Save Options Before Building</b>");
            this.buildAndRunOptionsLabel.UseMarkup = true;
            this.vbox66.Add(this.buildAndRunOptionsLabel);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox66[this.buildAndRunOptionsLabel]));
            w4.Position = 3;
            w4.Expand = false;
            w4.Fill = false;
            w4.Padding = ((uint)(6));
            // Container child vbox66.Gtk.Box+BoxChild
            this.hbox44 = new Gtk.HBox();
            this.hbox44.Name = "hbox44";
            this.hbox44.Spacing = 6;
            // Container child hbox44.Gtk.Box+BoxChild
            this.label71 = new Gtk.Label();
            this.label71.Name = "label71";
            this.label71.Xalign = 0F;
            this.label71.Yalign = 0F;
            this.label71.LabelProp = "    ";
            this.hbox44.Add(this.label71);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox44[this.label71]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox44.Gtk.Box+BoxChild
            this.vbox67 = new Gtk.VBox();
            this.vbox67.Name = "vbox67";
            this.vbox67.Spacing = 6;
            // Container child vbox67.Gtk.Box+BoxChild
            this.saveChangesRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_Save changes to open documents"));
            this.saveChangesRadioButton.Name = "saveChangesRadioButton";
            this.saveChangesRadioButton.Active = true;
            this.saveChangesRadioButton.DrawIndicator = true;
            this.saveChangesRadioButton.UseUnderline = true;
            this.saveChangesRadioButton.Group = new GLib.SList(System.IntPtr.Zero);
            this.vbox67.Add(this.saveChangesRadioButton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox67[this.saveChangesRadioButton]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox67.Gtk.Box+BoxChild
            this.promptChangesRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_Prompt to save changes to open documents"));
            this.promptChangesRadioButton.Name = "promptChangesRadioButton";
            this.promptChangesRadioButton.DrawIndicator = true;
            this.promptChangesRadioButton.UseUnderline = true;
            this.promptChangesRadioButton.Group = this.saveChangesRadioButton.Group;
            this.vbox67.Add(this.promptChangesRadioButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox67[this.promptChangesRadioButton]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox67.Gtk.Box+BoxChild
            this.noSaveRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("_Don't save changes to open documents "));
            this.noSaveRadioButton.Name = "noSaveRadioButton";
            this.noSaveRadioButton.DrawIndicator = true;
            this.noSaveRadioButton.UseUnderline = true;
            this.noSaveRadioButton.Group = this.saveChangesRadioButton.Group;
            this.vbox67.Add(this.noSaveRadioButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox67[this.noSaveRadioButton]));
            w8.Position = 2;
            w8.Expand = false;
            w8.Fill = false;
            this.hbox44.Add(this.vbox67);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox44[this.vbox67]));
            w9.Position = 1;
            w9.Expand = false;
            this.vbox66.Add(this.hbox44);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox66[this.hbox44]));
            w10.Position = 4;
            this.Add(this.vbox66);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
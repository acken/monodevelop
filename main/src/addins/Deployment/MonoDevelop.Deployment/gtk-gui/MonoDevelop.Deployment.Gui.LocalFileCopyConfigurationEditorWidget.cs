// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Deployment.Gui {
    
    internal partial class LocalFileCopyConfigurationEditorWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private MonoDevelop.Components.FolderEntry folderEntry;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Deployment.Gui.LocalFileCopyConfigurationEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.Deployment.Gui.LocalFileCopyConfigurationEditorWidget";
            // Container child MonoDevelop.Deployment.Gui.LocalFileCopyConfigurationEditorWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Target directory:");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.folderEntry = new MonoDevelop.Components.FolderEntry();
            this.folderEntry.Name = "folderEntry";
            this.vbox2.Add(this.folderEntry);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.folderEntry]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.folderEntry.PathChanged += new System.EventHandler(this.OnFolderEntryPathChanged);
        }
    }
}
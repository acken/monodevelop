// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    public partial class CombineEntryFeatureSelector {
        
        private Gtk.ScrolledWindow scrolled;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector";
            // Container child MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector.Gtk.Container+ContainerChild
            this.scrolled = new Gtk.ScrolledWindow();
            this.scrolled.CanFocus = true;
            this.scrolled.Name = "scrolled";
            this.Add(this.scrolled);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}

ADDIN_BUILD = $(top_builddir)/build/AddIns/VersionControl
ASSEMBLY = $(ADDIN_BUILD)/MonoDevelop.VersionControl.Git.dll

DEPS =  \
	$(top_builddir)/build/AddIns/VersionControl/MonoDevelop.VersionControl.dll \
	$(top_builddir)/build/bin/MonoDevelop.Core.dll \
	$(top_builddir)/build/bin/MonoDevelop.Ide.dll

REFS =  \
	$(GLIB_SHARP_LIBS) \
	$(GTK_SHARP_LIBS) \
	-r:Mono.Posix \
	-r:System \
	-r:System.Core

FILES =  \
	AssemblyInfo.cs \
	gtk-gui/generated.cs \
	gtk-gui/MonoDevelop.VersionControl.Git.PushDialog.cs \
	MonoDevelop.VersionControl.Git/Commands.cs \
	MonoDevelop.VersionControl.Git/CommitDialogExtensionWidget.cs \
	MonoDevelop.VersionControl.Git/GitClient.cs \
	MonoDevelop.VersionControl.Git/GitNodeBuilderExtension.cs \
	MonoDevelop.VersionControl.Git/GitRepository.cs \
	MonoDevelop.VersionControl.Git/GitService.cs \
	MonoDevelop.VersionControl.Git/GitVersionControl.cs \
	MonoDevelop.VersionControl.Git/PushDialog.cs

RES =  \
	gtk-gui/gui.stetic \
	MonoDevelop.VersionControl.Git.addin.xml

$(ASSEMBLY): $(build_sources) $(build_resources) $(DEPS)
	mkdir -p $(ADDIN_BUILD)
	$(CSC) $(CSC_FLAGS) $(build_sources) $(REFS) $(build_deps) $(build_resources:%=/resource:%) -out:$@ -target:library

$(ASSEMBLY).mdb: $(ASSEMBLY)

CLEANFILES = $(ASSEMBLY) $(ASSEMBLY).mdb
EXTRA_DIST = $(FILES) $(RES)

if ENABLE_GIT
all: $(ASSEMBLY) $(ASSEMBLY).mdb
else
all:
endif

if ENABLE_GIT
addindir = $(MD_ADDIN_DIR)/VersionControl
addin_DATA = $(ASSEMBLY) $(ASSEMBLY).mdb
endif

include $(top_srcdir)/Makefile.include

namespace DockableWebBrowser
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("f9c297fb-d3e5-4d05-b218-90e055d7cf6c")]
    public class Dockable_Web_Browser : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dockable_Web_Browser"/> class.
        /// </summary>
        public Dockable_Web_Browser() : base(null)
        {
            this.Caption = "Dockable Web Browser";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new Dockable_Web_BrowserControl();
        }
    }
}

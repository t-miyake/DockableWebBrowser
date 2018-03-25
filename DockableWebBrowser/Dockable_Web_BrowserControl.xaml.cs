using System;
using System.Reflection;

namespace DockableWebBrowser
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for Dockable_Web_BrowserControl.
    /// </summary>
    public partial class Dockable_Web_BrowserControl : UserControl
    {
        public const string FeatureBrowserEmulation = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
        private readonly Microsoft.Win32.RegistryKey _regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FeatureBrowserEmulation);
        readonly string _myName = System.IO.Path.GetFileName(Assembly.GetExecutingAssembly().Location);

        /// <summary>
        /// Initializes a new instance of the <see cref="Dockable_Web_BrowserControl"/> class.
        /// </summary>
        public Dockable_Web_BrowserControl()
        {
            this.InitializeComponent();
            _regkey.SetValue(_myName, 11001, Microsoft.Win32.RegistryValueKind.DWord);
            _regkey.Close();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Dockable Web Browser");
        }
    }
}
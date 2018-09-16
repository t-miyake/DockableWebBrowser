using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace DockableWebBrowser
{
    /// <summary>
    /// Interaction logic for Dockable_Web_BrowserControl.
    /// </summary>
    public partial class Dockable_Web_BrowserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dockable_Web_BrowserControl"/> class.
        /// </summary>
        public Dockable_Web_BrowserControl()
        {
            InitializeComponent();
            WebView.Source = new Uri("https://www.google.co.jp/");
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
// ------------------------------------------------------------------------------------
// <copyright file="About.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Atalasoft.Demo.BarcodeReader
{
    /// <summary>
    /// Represents about dialog.
    /// </summary>
    public partial class About : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the About class.
        /// </summary>
        /// <param name="windowTitle">The head title of the about window.</param>
        /// <param name="progName">The name of the program that this about window is called from.</param>
        public About(string windowTitle, string progName)
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            SetWindowTitle(windowTitle);
            _demoTitle.Text = progName;

            // Load assembly versions.
            var asm = Assembly.GetExecutingAssembly();
            var refs = asm.GetReferencedAssemblies();
            var msg = new StringBuilder();

            foreach (var name in refs)
            {
                if (!name.Name.StartsWith("Atalasoft")) 
                    continue;
                if (msg.Length != 0) msg.Append("\r\n");
                msg.Append(name.Name + " - " + name.Version);
            }

            _txtAssemblies.Text = msg.ToString();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the description of this window.
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region Event handlers

        private void OnButtonOkClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnDownloadDotImageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.atalasoft.com/products/download/dotimage");
        }

        private void OnDownloadHelpInstallerLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.atalasoft.com/support/dotimage/help/install");
        }

        private void OnDemoGalleryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.atalasoft.com/support/sample-applications");
        }

        private void OnLogoClick(object sender, EventArgs e)
        {
            Process.Start("www.atalasoft.com");
        }

        private void OnLogoMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void OnLogoMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void OnAboutLoad(object sender, EventArgs e)
        {
            _description.Text = Description;
        }

        #endregion

        #region Private methods

        private void SetWindowTitle(string windowTitle)
        {
            Text = windowTitle;
        }

        #endregion
    }
}

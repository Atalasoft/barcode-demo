// ------------------------------------------------------------------------------------
// <copyright file="About.Designer.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows.Forms;

namespace Atalasoft.Demo.BarcodeReader
{
    /// <content>
    /// Contains auto-generated functionality for the About class.
    /// </content>
    public partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly IContainer components = null;

        private Label _description;
        private Label _linksDescription;
        private LinkLabel _downloadHelpLinkLabel;
        private Button _buttonOk;
        private LinkLabel _demoGalleryLinkLabel;
        private LinkLabel _downloadDotImageLinkLabel;
        private Label _phoneNumber;
        private PictureBox _logo;
        private Label _demoTitle;
        private GroupBox _assembliesGroupBox;
        private TextBox _txtAssemblies;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this._description = new System.Windows.Forms.Label();
            this._linksDescription = new System.Windows.Forms.Label();
            this._downloadHelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this._buttonOk = new System.Windows.Forms.Button();
            this._demoGalleryLinkLabel = new System.Windows.Forms.LinkLabel();
            this._downloadDotImageLinkLabel = new System.Windows.Forms.LinkLabel();
            this._phoneNumber = new System.Windows.Forms.Label();
            this._logo = new System.Windows.Forms.PictureBox();
            this._demoTitle = new System.Windows.Forms.Label();
            this._assembliesGroupBox = new System.Windows.Forms.GroupBox();
            this._txtAssemblies = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._logo)).BeginInit();
            this._assembliesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _description
            // 
            this._description.Location = new System.Drawing.Point(19, 64);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(456, 97);
            this._description.TabIndex = 1;
            this._description.Text = "[demo description here]";
            // 
            // _linksDescription
            // 
            this._linksDescription.Location = new System.Drawing.Point(56, 168);
            this._linksDescription.Name = "_linksDescription";
            this._linksDescription.Size = new System.Drawing.Size(336, 16);
            this._linksDescription.TabIndex = 2;
            this._linksDescription.Text = "Please Check the following for help programming with DotImage:";
            // 
            // _downloadHelpLinkLabel
            // 
            this._downloadHelpLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 32);
            this._downloadHelpLinkLabel.Location = new System.Drawing.Point(120, 224);
            this._downloadHelpLinkLabel.Name = "_downloadHelpLinkLabel";
            this._downloadHelpLinkLabel.Size = new System.Drawing.Size(200, 16);
            this._downloadHelpLinkLabel.TabIndex = 4;
            this._downloadHelpLinkLabel.TabStop = true;
            this._downloadHelpLinkLabel.Text = "Download DotImage Help Installer";
            this._downloadHelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnDownloadHelpInstallerLinkClicked);
            // 
            // _buttonOk
            // 
            this._buttonOk.BackColor = System.Drawing.SystemColors.Control;
            this._buttonOk.Location = new System.Drawing.Point(358, 560);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(104, 24);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = false;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _demoGalleryLinkLabel
            // 
            this._demoGalleryLinkLabel.Location = new System.Drawing.Point(120, 248);
            this._demoGalleryLinkLabel.Name = "_demoGalleryLinkLabel";
            this._demoGalleryLinkLabel.Size = new System.Drawing.Size(192, 16);
            this._demoGalleryLinkLabel.TabIndex = 6;
            this._demoGalleryLinkLabel.TabStop = true;
            this._demoGalleryLinkLabel.Text = "Barcode Reader Demo Home";
            this._demoGalleryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnDemoGalleryLinkClicked);
            // 
            // _downloadDotImageLinkLabel
            // 
            this._downloadDotImageLinkLabel.Location = new System.Drawing.Point(120, 201);
            this._downloadDotImageLinkLabel.Name = "_downloadDotImageLinkLabel";
            this._downloadDotImageLinkLabel.Size = new System.Drawing.Size(184, 23);
            this._downloadDotImageLinkLabel.TabIndex = 7;
            this._downloadDotImageLinkLabel.TabStop = true;
            this._downloadDotImageLinkLabel.Text = "Download the latest DotImage";
            this._downloadDotImageLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnDownloadDotImageLinkClicked);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Location = new System.Drawing.Point(120, 296);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(264, 23);
            this._phoneNumber.TabIndex = 8;
            this._phoneNumber.Text = "Gold Support Members Only, Call (866) 568-0129";
            // 
            // _logo
            // 
            this._logo.Image = ((System.Drawing.Image)(resources.GetObject("_logo.Image")));
            this._logo.Location = new System.Drawing.Point(50, 498);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(264, 88);
            this._logo.TabIndex = 9;
            this._logo.TabStop = false;
            this._logo.Click += new System.EventHandler(this.OnLogoClick);
            this._logo.MouseEnter += new System.EventHandler(this.OnLogoMouseEnter);
            this._logo.MouseLeave += new System.EventHandler(this.OnLogoMouseLeave);
            // 
            // _demoTitle
            // 
            this._demoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._demoTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this._demoTitle.Location = new System.Drawing.Point(43, 16);
            this._demoTitle.Name = "_demoTitle";
            this._demoTitle.Size = new System.Drawing.Size(408, 32);
            this._demoTitle.TabIndex = 10;
            this._demoTitle.Text = "[demo title here]";
            this._demoTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _assembliesGroupBox
            // 
            this._assembliesGroupBox.Controls.Add(this._txtAssemblies);
            this._assembliesGroupBox.Location = new System.Drawing.Point(88, 336);
            this._assembliesGroupBox.Name = "_assembliesGroupBox";
            this._assembliesGroupBox.Size = new System.Drawing.Size(296, 151);
            this._assembliesGroupBox.TabIndex = 11;
            this._assembliesGroupBox.TabStop = false;
            this._assembliesGroupBox.Text = "Assemblies";
            // 
            // _txtAssemblies
            // 
            this._txtAssemblies.BackColor = System.Drawing.Color.White;
            this._txtAssemblies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtAssemblies.Location = new System.Drawing.Point(8, 16);
            this._txtAssemblies.Multiline = true;
            this._txtAssemblies.Name = "_txtAssemblies";
            this._txtAssemblies.Size = new System.Drawing.Size(275, 128);
            this._txtAssemblies.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 600);
            this.Controls.Add(this._assembliesGroupBox);
            this.Controls.Add(this._demoTitle);
            this.Controls.Add(this._logo);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this._downloadDotImageLinkLabel);
            this.Controls.Add(this._demoGalleryLinkLabel);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._downloadHelpLinkLabel);
            this.Controls.Add(this._linksDescription);
            this.Controls.Add(this._description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[about title here]";
            this.Load += new System.EventHandler(this.OnAboutLoad);
            ((System.ComponentModel.ISupportInitialize)(this._logo)).EndInit();
            this._assembliesGroupBox.ResumeLayout(false);
            this._assembliesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
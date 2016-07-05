// ------------------------------------------------------------------------------------
// <copyright file="Barcoder.Designer.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows.Forms;
using Atalasoft.Imaging.WinControls;

namespace Atalasoft.Demo.BarcodeReader
{
    /// <content>
    /// Contains auto-generated functionality for the Customer class.
    /// </content>
    public partial class Barcoder
    {
        // members used for the UI
        private Label _label1;
        private CheckBox _shrinkToFit;
        private CheckBox _showBoundingRects;
        private CheckBox _showBoundingBoxes;
        private OpenFileDialog _openFileDialog;
        private Button _openButton;
        private Button _recognizeButton;
        private CheckedListBox _barcodeSymbologyList;
        private Button _btnSelectAllSymbologies;
        private Button _btnClearSymbologies;
        private GroupBox _groupBox1;
        private CheckedListBox _scanDirectionList;
        private Button _btnSelectAllDirections;
        private Button _btnClearAllDirections;
        private GroupBox _groupBox2;
        private TrackBar _scanInterval;
        private Label _scanIntervalLabel;
        private GroupBox _groupBox3;
        private TrackBar _expectedBarCodes;
        private Label _expectedBarcodesLabel;
        private GroupBox _groupBox4;
        private Button _aboutBtn;
        private CheckBox _useAutomaticThresholdingCheckBox;
        private TextBox _statusBox;
        private WorkspaceViewer _workspaceViewer;
        private RadioButton _btnMorphoErode;
        private GroupBox _groupBox5;
        private RadioButton _btnMorphoDilate;
        private RadioButton _btnMorphoNone;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcoder));
            this._label1 = new System.Windows.Forms.Label();
            this._shrinkToFit = new System.Windows.Forms.CheckBox();
            this._showBoundingRects = new System.Windows.Forms.CheckBox();
            this._showBoundingBoxes = new System.Windows.Forms.CheckBox();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._openButton = new System.Windows.Forms.Button();
            this._recognizeButton = new System.Windows.Forms.Button();
            this._barcodeSymbologyList = new System.Windows.Forms.CheckedListBox();
            this._btnSelectAllSymbologies = new System.Windows.Forms.Button();
            this._btnClearSymbologies = new System.Windows.Forms.Button();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._scanDirectionList = new System.Windows.Forms.CheckedListBox();
            this._btnSelectAllDirections = new System.Windows.Forms.Button();
            this._btnClearAllDirections = new System.Windows.Forms.Button();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._scanInterval = new System.Windows.Forms.TrackBar();
            this._scanIntervalLabel = new System.Windows.Forms.Label();
            this._groupBox3 = new System.Windows.Forms.GroupBox();
            this._expectedBarCodes = new System.Windows.Forms.TrackBar();
            this._expectedBarcodesLabel = new System.Windows.Forms.Label();
            this._groupBox4 = new System.Windows.Forms.GroupBox();
            this._aboutBtn = new System.Windows.Forms.Button();
            this._useAutomaticThresholdingCheckBox = new System.Windows.Forms.CheckBox();
            this._statusBox = new System.Windows.Forms.TextBox();
            this._workspaceViewer = new Atalasoft.Imaging.WinControls.WorkspaceViewer();
            this._btnMorphoErode = new System.Windows.Forms.RadioButton();
            this._groupBox5 = new System.Windows.Forms.GroupBox();
            this._btnMorphoDilate = new System.Windows.Forms.RadioButton();
            this._btnMorphoNone = new System.Windows.Forms.RadioButton();
            this._groupBox1.SuspendLayout();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scanInterval)).BeginInit();
            this._groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._expectedBarCodes)).BeginInit();
            this._groupBox4.SuspendLayout();
            this._groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this._label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.ForeColor = System.Drawing.Color.Orange;
            this._label1.Location = new System.Drawing.Point(12, -3);
            this._label1.Name = "label1";
            this._label1.Size = new System.Drawing.Size(476, 27);
            this._label1.TabIndex = 1;
            this._label1.Text = "Atalasoft Barcode Reader Demo";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._label1.UseMnemonic = false;
            // 
            // shrinkToFit
            // 
            this._shrinkToFit.Location = new System.Drawing.Point(20, 25);
            this._shrinkToFit.Name = "shrinkToFit";
            this._shrinkToFit.Size = new System.Drawing.Size(120, 18);
            this._shrinkToFit.TabIndex = 11;
            this._shrinkToFit.Text = "Shrink Image to Fit";
            this._shrinkToFit.CheckedChanged += new System.EventHandler(this.ShrinkToFit_CheckedChanged);
            // 
            // showBoundingRects
            // 
            this._showBoundingRects.Checked = true;
            this._showBoundingRects.CheckState = System.Windows.Forms.CheckState.Checked;
            this._showBoundingRects.Location = new System.Drawing.Point(148, 25);
            this._showBoundingRects.Name = "showBoundingRects";
            this._showBoundingRects.Size = new System.Drawing.Size(168, 18);
            this._showBoundingRects.TabIndex = 12;
            this._showBoundingRects.Text = "Show Bounding Rectangles";
            this._showBoundingRects.CheckedChanged += new System.EventHandler(this.ShowBoundingRects_CheckedChanged);
            // 
            // showBoundingBoxes
            // 
            this._showBoundingBoxes.Checked = true;
            this._showBoundingBoxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this._showBoundingBoxes.Location = new System.Drawing.Point(324, 25);
            this._showBoundingBoxes.Name = "showBoundingBoxes";
            this._showBoundingBoxes.Size = new System.Drawing.Size(144, 18);
            this._showBoundingBoxes.TabIndex = 13;
            this._showBoundingBoxes.Text = "Show Bounding Boxes";
            this._showBoundingBoxes.CheckedChanged += new System.EventHandler(this.ShowBoundingBoxes_CheckedChanged);
            // 
            // openButton
            // 
            this._openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._openButton.Location = new System.Drawing.Point(22, 285);
            this._openButton.Name = "openButton";
            this._openButton.Size = new System.Drawing.Size(96, 23);
            this._openButton.TabIndex = 2;
            this._openButton.Text = "Open Image...";
            this._openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // recognizeButton
            // 
            this._recognizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._recognizeButton.Location = new System.Drawing.Point(134, 285);
            this._recognizeButton.Name = "recognizeButton";
            this._recognizeButton.Size = new System.Drawing.Size(80, 24);
            this._recognizeButton.TabIndex = 4;
            this._recognizeButton.Text = "Recognize...";
            this._recognizeButton.Click += new System.EventHandler(this.RecognizeButton_Click);
            // 
            // barcodeSymbologyList
            // 
            this._barcodeSymbologyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._barcodeSymbologyList.CheckOnClick = true;
            this._barcodeSymbologyList.Location = new System.Drawing.Point(8, 16);
            this._barcodeSymbologyList.Name = "barcodeSymbologyList";
            this._barcodeSymbologyList.Size = new System.Drawing.Size(174, 64);
            this._barcodeSymbologyList.TabIndex = 6;
            this._barcodeSymbologyList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.BarcodeSymbologyList_ItemCheck);
            // 
            // btnSelectAllSymbologies
            // 
            this._btnSelectAllSymbologies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectAllSymbologies.Location = new System.Drawing.Point(188, 19);
            this._btnSelectAllSymbologies.Name = "btnSelectAllSymbologies";
            this._btnSelectAllSymbologies.Size = new System.Drawing.Size(64, 32);
            this._btnSelectAllSymbologies.TabIndex = 7;
            this._btnSelectAllSymbologies.Text = "Select All";
            this._btnSelectAllSymbologies.UseVisualStyleBackColor = true;
            this._btnSelectAllSymbologies.Click += new System.EventHandler(this.BtnSelectAllSymbologies_Click);
            // 
            // btnClearSymbologies
            // 
            this._btnClearSymbologies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClearSymbologies.Location = new System.Drawing.Point(188, 57);
            this._btnClearSymbologies.Name = "btnClearSymbologies";
            this._btnClearSymbologies.Size = new System.Drawing.Size(64, 23);
            this._btnClearSymbologies.TabIndex = 8;
            this._btnClearSymbologies.Text = "Clear All";
            this._btnClearSymbologies.UseVisualStyleBackColor = true;
            this._btnClearSymbologies.Click += new System.EventHandler(this.BtnClearSymbologies_Click);
            // 
            // groupBox1
            // 
            this._groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox1.Controls.Add(this._btnClearSymbologies);
            this._groupBox1.Controls.Add(this._btnSelectAllSymbologies);
            this._groupBox1.Controls.Add(this._barcodeSymbologyList);
            this._groupBox1.Location = new System.Drawing.Point(222, 285);
            this._groupBox1.Name = "groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(260, 88);
            this._groupBox1.TabIndex = 7;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Barcode Types";
            // 
            // scanDirectionList
            // 
            this._scanDirectionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._scanDirectionList.CheckOnClick = true;
            this._scanDirectionList.Location = new System.Drawing.Point(8, 16);
            this._scanDirectionList.Name = "scanDirectionList";
            this._scanDirectionList.Size = new System.Drawing.Size(174, 64);
            this._scanDirectionList.TabIndex = 9;
            this._scanDirectionList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ScanDirectionList_ItemCheck);
            // 
            // btnSelectAllDirections
            // 
            this._btnSelectAllDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectAllDirections.Location = new System.Drawing.Point(188, 16);
            this._btnSelectAllDirections.Name = "btnSelectAllDirections";
            this._btnSelectAllDirections.Size = new System.Drawing.Size(64, 35);
            this._btnSelectAllDirections.TabIndex = 9;
            this._btnSelectAllDirections.Text = "Select All";
            this._btnSelectAllDirections.UseVisualStyleBackColor = true;
            this._btnSelectAllDirections.Click += new System.EventHandler(this.BtnSelectAllDirections_Click);
            // 
            // btnClearAllDirections
            // 
            this._btnClearAllDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClearAllDirections.Location = new System.Drawing.Point(188, 57);
            this._btnClearAllDirections.Name = "btnClearAllDirections";
            this._btnClearAllDirections.Size = new System.Drawing.Size(64, 23);
            this._btnClearAllDirections.TabIndex = 10;
            this._btnClearAllDirections.Text = "Clear All";
            this._btnClearAllDirections.UseVisualStyleBackColor = true;
            this._btnClearAllDirections.Click += new System.EventHandler(this.BtnClearAllDirections_Click);
            // 
            // groupBox2
            // 
            this._groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox2.Controls.Add(this._btnClearAllDirections);
            this._groupBox2.Controls.Add(this._btnSelectAllDirections);
            this._groupBox2.Controls.Add(this._scanDirectionList);
            this._groupBox2.Location = new System.Drawing.Point(222, 373);
            this._groupBox2.Name = "groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(260, 88);
            this._groupBox2.TabIndex = 8;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "Scan Directions";
            // 
            // scanInterval
            // 
            this._scanInterval.AutoSize = false;
            this._scanInterval.Location = new System.Drawing.Point(8, 40);
            this._scanInterval.Maximum = 20;
            this._scanInterval.Minimum = 1;
            this._scanInterval.Name = "scanInterval";
            this._scanInterval.Size = new System.Drawing.Size(176, 20);
            this._scanInterval.TabIndex = 0;
            this._scanInterval.TickFrequency = 5;
            this._scanInterval.Value = 5;
            this._scanInterval.ValueChanged += new System.EventHandler(this.ScanInterval_ValueChanged);
            // 
            // scanIntervalLabel
            // 
            this._scanIntervalLabel.Location = new System.Drawing.Point(88, 16);
            this._scanIntervalLabel.Name = "scanIntervalLabel";
            this._scanIntervalLabel.Size = new System.Drawing.Size(24, 16);
            this._scanIntervalLabel.TabIndex = 1;
            this._scanIntervalLabel.Text = "5";
            this._scanIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._scanIntervalLabel.UseMnemonic = false;
            // 
            // groupBox3
            // 
            this._groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._groupBox3.Controls.Add(this._scanIntervalLabel);
            this._groupBox3.Controls.Add(this._scanInterval);
            this._groupBox3.Location = new System.Drawing.Point(22, 317);
            this._groupBox3.Name = "groupBox3";
            this._groupBox3.Size = new System.Drawing.Size(192, 64);
            this._groupBox3.TabIndex = 9;
            this._groupBox3.TabStop = false;
            this._groupBox3.Text = "Scan Interval";
            // 
            // expectedBarCodes
            // 
            this._expectedBarCodes.AutoSize = false;
            this._expectedBarCodes.Location = new System.Drawing.Point(8, 40);
            this._expectedBarCodes.Minimum = 1;
            this._expectedBarCodes.Name = "expectedBarCodes";
            this._expectedBarCodes.Size = new System.Drawing.Size(176, 20);
            this._expectedBarCodes.TabIndex = 1;
            this._expectedBarCodes.TickFrequency = 3;
            this._expectedBarCodes.Value = 1;
            this._expectedBarCodes.ValueChanged += new System.EventHandler(this.ExpectedBarCodes_ValueChanged);
            // 
            // expectedBarcodesLabel
            // 
            this._expectedBarcodesLabel.Location = new System.Drawing.Point(88, 16);
            this._expectedBarcodesLabel.Name = "expectedBarcodesLabel";
            this._expectedBarcodesLabel.Size = new System.Drawing.Size(24, 16);
            this._expectedBarcodesLabel.TabIndex = 2;
            this._expectedBarcodesLabel.Text = "1";
            this._expectedBarcodesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._expectedBarcodesLabel.UseMnemonic = false;
            // 
            // groupBox4
            // 
            this._groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._groupBox4.Controls.Add(this._expectedBarcodesLabel);
            this._groupBox4.Controls.Add(this._expectedBarCodes);
            this._groupBox4.Location = new System.Drawing.Point(22, 397);
            this._groupBox4.Name = "groupBox4";
            this._groupBox4.Size = new System.Drawing.Size(192, 64);
            this._groupBox4.TabIndex = 10;
            this._groupBox4.TabStop = false;
            this._groupBox4.Text = "Number of Expected Barcodes";
            // 
            // aboutBtn
            // 
            this._aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._aboutBtn.Location = new System.Drawing.Point(404, 602);
            this._aboutBtn.Name = "aboutBtn";
            this._aboutBtn.Size = new System.Drawing.Size(88, 24);
            this._aboutBtn.TabIndex = 14;
            this._aboutBtn.Text = "About ...";
            this._aboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // useAutomaticThresholding_CheckBox
            // 
            this._useAutomaticThresholdingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._useAutomaticThresholdingCheckBox.AutoSize = true;
            this._useAutomaticThresholdingCheckBox.Checked = true;
            this._useAutomaticThresholdingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._useAutomaticThresholdingCheckBox.Location = new System.Drawing.Point(18, 607);
            this._useAutomaticThresholdingCheckBox.Name = "useAutomaticThresholding_CheckBox";
            this._useAutomaticThresholdingCheckBox.Size = new System.Drawing.Size(346, 17);
            this._useAutomaticThresholdingCheckBox.TabIndex = 15;
            this._useAutomaticThresholdingCheckBox.Text = "Enable Automatic Thresholding (Try Toggling If Codes Not Reading)";
            this._useAutomaticThresholdingCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusBox
            // 
            this._statusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._statusBox.Location = new System.Drawing.Point(14, 469);
            this._statusBox.Multiline = true;
            this._statusBox.Name = "statusBox";
            this._statusBox.ReadOnly = true;
            this._statusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._statusBox.Size = new System.Drawing.Size(468, 72);
            this._statusBox.TabIndex = 5;
            this._statusBox.DoubleClick += new System.EventHandler(this.StatusBox_DoubleClick);
            // 
            // workspaceViewer
            // 
            this._workspaceViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._workspaceViewer.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray;
            this._workspaceViewer.DisplayProfile = null;
            this._workspaceViewer.Location = new System.Drawing.Point(30, 49);
            this._workspaceViewer.Magnifier.BackColor = System.Drawing.Color.White;
            this._workspaceViewer.Magnifier.BorderColor = System.Drawing.Color.Black;
            this._workspaceViewer.Magnifier.Size = new System.Drawing.Size(100, 100);
            this._workspaceViewer.Name = "workspaceViewer";
            this._workspaceViewer.OutputProfile = null;
            this._workspaceViewer.Selection = null;
            this._workspaceViewer.Size = new System.Drawing.Size(444, 228);
            this._workspaceViewer.TabIndex = 0;
            this._workspaceViewer.Text = "The Image";
            this._workspaceViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkspaceViewer_Paint);
            // 
            // btnMorphoErode
            // 
            this._btnMorphoErode.AutoSize = true;
            this._btnMorphoErode.Location = new System.Drawing.Point(283, 14);
            this._btnMorphoErode.Name = "btnMorphoErode";
            this._btnMorphoErode.Size = new System.Drawing.Size(53, 17);
            this._btnMorphoErode.TabIndex = 2;
            this._btnMorphoErode.Text = "Erode";
            this._btnMorphoErode.UseVisualStyleBackColor = true;
            this._btnMorphoErode.CheckedChanged += new System.EventHandler(this.BtnMorphoErode_CheckedChanged);
            // 
            // groupBox5
            // 
            this._groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._groupBox5.Controls.Add(this._btnMorphoErode);
            this._groupBox5.Controls.Add(this._btnMorphoDilate);
            this._groupBox5.Controls.Add(this._btnMorphoNone);
            this._groupBox5.Location = new System.Drawing.Point(12, 560);
            this._groupBox5.Name = "groupBox5";
            this._groupBox5.Size = new System.Drawing.Size(352, 36);
            this._groupBox5.TabIndex = 17;
            this._groupBox5.TabStop = false;
            this._groupBox5.Text = "Morphology Command to Apply";
            // 
            // btnMorphoDilate
            // 
            this._btnMorphoDilate.AutoSize = true;
            this._btnMorphoDilate.Location = new System.Drawing.Point(150, 14);
            this._btnMorphoDilate.Name = "btnMorphoDilate";
            this._btnMorphoDilate.Size = new System.Drawing.Size(52, 17);
            this._btnMorphoDilate.TabIndex = 1;
            this._btnMorphoDilate.Text = "Dilate";
            this._btnMorphoDilate.UseVisualStyleBackColor = true;
            this._btnMorphoDilate.CheckedChanged += new System.EventHandler(this.BtnMorphoDilate_CheckedChanged);
            // 
            // btnMorphoNone
            // 
            this._btnMorphoNone.AutoSize = true;
            this._btnMorphoNone.Checked = true;
            this._btnMorphoNone.Location = new System.Drawing.Point(6, 14);
            this._btnMorphoNone.Name = "btnMorphoNone";
            this._btnMorphoNone.Size = new System.Drawing.Size(51, 17);
            this._btnMorphoNone.TabIndex = 0;
            this._btnMorphoNone.TabStop = true;
            this._btnMorphoNone.Text = "None";
            this._btnMorphoNone.UseVisualStyleBackColor = true;
            this._btnMorphoNone.CheckedChanged += new System.EventHandler(this.BtnMorphoNone_CheckedChanged);
            // 
            // Barcoder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(508, 632);
            this.Controls.Add(this._groupBox5);
            this.Controls.Add(this._useAutomaticThresholdingCheckBox);
            this.Controls.Add(this._aboutBtn);
            this.Controls.Add(this._showBoundingBoxes);
            this.Controls.Add(this._showBoundingRects);
            this.Controls.Add(this._statusBox);
            this.Controls.Add(this._workspaceViewer);
            this.Controls.Add(this._shrinkToFit);
            this.Controls.Add(this._groupBox4);
            this.Controls.Add(this._groupBox3);
            this.Controls.Add(this._groupBox2);
            this.Controls.Add(this._groupBox1);
            this.Controls.Add(this._recognizeButton);
            this.Controls.Add(this._openButton);
            this.Controls.Add(this._label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcoder";
            this.Text = "Atalasoft Barcode Reader Demo";
            this.Load += new System.EventHandler(this.Barcoder_Load);
            this._groupBox1.ResumeLayout(false);
            this._groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._scanInterval)).EndInit();
            this._groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._expectedBarCodes)).EndInit();
            this._groupBox4.ResumeLayout(false);
            this._groupBox5.ResumeLayout(false);
            this._groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

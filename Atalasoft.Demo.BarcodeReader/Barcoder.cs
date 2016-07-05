// ------------------------------------------------------------------------------------
// <copyright file="Barcoder.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Atalasoft.Barcoding.Reading;
using Atalasoft.Demo.BarcodeReader.Properties;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.ImageProcessing.Document;
using Atalasoft.Imaging.WinControls;

namespace Atalasoft.Demo.BarcodeReader
{
    /// <summary>
    /// Demonstration of Atalasoft barcode recognition.
    /// </summary>
    public partial class Barcoder : Form
    {
        private AtalaImage _tmpImg;

        // members used for barcode recognition
        // maps from internal enumerations to UIStrings
        private readonly SymbologyMap[] _mySymbologyMap;
        private readonly ScanDirectionMap[] _directionMap;

        private BarCode[] _finalResults;
        private ReadOpts _options;
        private bool _imageLoaded;

        /// <summary>
        /// Initializes a new instance of the <see cref="Barcoder"/> class.
        /// </summary>
        public Barcoder()
        {
            // build the maps first since they get used by the UI
            // so make sure that they're constructed before the UI
            // gets built.
            _mySymbologyMap = new[] {
                new SymbologyMap("Australia Post", Symbologies.AustraliaPost),
                new SymbologyMap("Codabar", Symbologies.Codabar),
                new SymbologyMap("Code 11", Symbologies.Code11),
                new SymbologyMap("Code 128", Symbologies.Code128),
                new SymbologyMap("Code 32", Symbologies.Code32),
                new SymbologyMap("Code 39", Symbologies.Code39),
                new SymbologyMap("Code 93", Symbologies.Code93),
                new SymbologyMap("Data Matrix", Symbologies.Datamatrix),
                new SymbologyMap("Ean 13", Symbologies.Ean13),
                new SymbologyMap("Ean 8", Symbologies.Ean8),
                new SymbologyMap("I 2 of 5", Symbologies.I2of5),
                new SymbologyMap("Intelligent Mail", Symbologies.IntelligentMail),
                new SymbologyMap("ITF-14", Symbologies.Itf14),
                new SymbologyMap("Micro QR Code", Symbologies.MicroQr),
                new SymbologyMap("Patch", Symbologies.Patch),
                new SymbologyMap("PDF 417", Symbologies.Pdf417),
                new SymbologyMap("Planet", Symbologies.Planet),
                new SymbologyMap("Plus 2", Symbologies.Plus2),
                new SymbologyMap("Plus 5", Symbologies.Plus5),
                new SymbologyMap("Postnet", Symbologies.Postnet),
                new SymbologyMap("QR", Symbologies.Qr),
                new SymbologyMap("Royal Mail +4 State Customer Code", Symbologies.Rm4scc),
                new SymbologyMap("RSS-14", Symbologies.Rss14),
                new SymbologyMap("RSS Limited", Symbologies.RssLimited),
                new SymbologyMap("Telepen", Symbologies.Telepen),
                new SymbologyMap("UPC A", Symbologies.Upca),
                new SymbologyMap("UPC E", Symbologies.Upce),
             };

            _directionMap = new[] {
                new ScanDirectionMap("Left to Right", Directions.East),
                new ScanDirectionMap("Right to Left", Directions.West),
                new ScanDirectionMap("Top to Bottom", Directions.South),
                new ScanDirectionMap("Bottom to Top", Directions.North),
                new ScanDirectionMap("Bottom Left to Top Right", Directions.NorthEast),
                new ScanDirectionMap("Top Left to Bottom Right", Directions.SouthEast),
                new ScanDirectionMap("Top Right to Bottom Left", Directions.SouthWest),
                new ScanDirectionMap("Bottom Right to Top Left", Directions.NorthWest),
            };

            // Ensure we'll open the image with one of our licensed decoders
            WinDemoHelperMethods.PopulateDecoders(RegisteredDecoders.Decoders);

            // Sets the default Pixel Format Changer to use Thresholding.
            // This may cause problems for people with PhotoFree or PhotoPro licenses.
            AtalaImage.PixelFormatChanger = new DocumentPixelFormatChanger(new AtalaPixelFormatChanger());

            InitializeComponent();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.Run(new Barcoder());
        }

        private static Point ScaleAndOffset(Point source, double zoom, Point offset)
        {
            // scale and offset a point from image space into view space
            var dest = new Point(source.X, source.Y);
            dest.X = (int)(dest.X * zoom);
            dest.Y = (int)(dest.Y * zoom);
            dest.Offset(offset.X, offset.Y);

            return dest;
        }
        
        private void Barcoder_Load(object sender, EventArgs e)
        {
            _recognizeButton.Enabled = false;

            // set a few reasonable default options
            _options = new ReadOpts
            {
                Symbology = Symbologies.Code39,
                Direction = Directions.East,

                // counter-intuitive - these defaults get pulled from the UI instead
                // of being pushed into the UI
                ScanInterval = _scanInterval.Value,
                ScanBarsToRead = _expectedBarCodes.Value
            };

            // map the options into the UI
            MapBarcodeSymbologies(_barcodeSymbologyList, _options, _mySymbologyMap);
            MapScanDirections(_scanDirectionList, _options, _directionMap);
            _statusBox.AppendText("Application loaded.  Click \"Open Image\" to load an image.\r\n");

            // This should point to the "DotImage 7.0\Images\Barcodes" folder.
            _openFileDialog.FileName = Path.GetFullPath(@"..\..\Images\Barcodes\Code39Scanned.gif");
            if (!File.Exists(_openFileDialog.FileName))
            {
                _openFileDialog.FileName = Path.GetFullPath(@"..\..\..\..\..\Images\Barcodes\Code39Scanned.gif");
                if (!File.Exists(_openFileDialog.FileName))
                    _openFileDialog.FileName = string.Empty;
            }
        }

        private void MapScanDirections(CheckedListBox listBox, ReadOpts theOptions, ScanDirectionMap[] map)
        {
            // put each scan direction into the check box,
            // checking it as needed.
            for (var i = 0; i < map.Length; i++)
            {
                listBox.Items.Add(map[i]);
                if ((theOptions.Direction & map[i].Direction) != 0)
                {
                    listBox.SetItemChecked(i, true);
                }
            }
        }

        // To follow the process of recognition of a barcode, recognizeButton_Click
        // and recognizeBarcodes are the main methods that should be examined.
        // recognizeButton_Click handles nearly all the user-interface feedback
        // leaving the work of recognition to recognizeBarcodes, which is written
        // as much as possible to be separate from the UI and the specific
        // implementation.
        //
        // Various options are set in the callback methods.
        private void RecognizeButton_Click(object sender, EventArgs e)
        {
            // Respond to a recognize request - this button is disabled if it's not
            // appropriate to do a recognize (options that don't make sense,
            // no file loaded)
            BarCode[] results;

            // swap in a wait cursor
            var savedCursor = Cursor;
            Cursor = Cursors.WaitCursor;

            // time the process
            var start = DateTime.Now;

            if (_workspaceViewer.Image == null)
            {
                MessageBox.Show(Resources.Barcoder_RecognizeButton_LoadImage);
                return;
            }

            using (var readEngine = new BarCodeReader(_workspaceViewer.Image, _useAutomaticThresholdingCheckBox.Checked))
            {
                results = RecognizeBarcodes(readEngine, _options);
            }

            var end = DateTime.Now;
            var elapsed = end - start;

            Cursor = savedCursor;

            _statusBox.AppendText(results.Length + " total barcode" +
                (results.Length == 1 ? string.Empty : "s") + " found.\r\n");

            if (results.Length > 0)
            {
                _statusBox.AppendText("Found " + results.Length +
                    " barcode" + (results.Length > 1 ? "s" : string.Empty) + ":\r\n");
                for (var i = 0; i < results.Length; i++)
                {
                    _statusBox.AppendText("      Result #" + (i + 1) + "\r\n");
                    _statusBox.AppendText("           Direction: " + results[i].ReadDirection.ToString() + "\r\n");
                    _statusBox.AppendText("           Symbology: " + SymbologyToString(results[i].Symbology, _mySymbologyMap) + "\r\n");
                    _statusBox.AppendText("           Text read: " + results[i].DataString + "\r\n");
                }
            }

            _statusBox.AppendText("Total time: " + string.Format("{0:0.000}", elapsed.TotalSeconds) +
                " seconds.\r\n");

            _finalResults = results;
            _workspaceViewer.Invalidate();
        }

        // Read a set of barcodes from an image.
        private BarCode[] RecognizeBarcodes(BarCodeReader reader, ReadOpts optionsIn)
        {
            BarCode[] results = null;
            var options = new ReadOpts(optionsIn);

            if (options.Symbology == 0)
            {
                return null;
            }

            try
            {
                results = reader.ReadBars(options);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _statusBox.AppendText("Range error in options: " + ex.Message + "\r\n");
            }
            catch (Exception ex)
            {
                _statusBox.AppendText("General error: " + ex.Message + "\r\n");
            }

            return results;
        }
        
        private void BtnSelectAllDirections_Click(object sender, EventArgs e)
        {
            CheckUncheckAllListItems(_scanDirectionList, true);
        }

        private void BtnClearAllDirections_Click(object sender, EventArgs e)
        {
            CheckUncheckAllListItems(_scanDirectionList, false);
        }

        private void MapBarcodeSymbologies(CheckedListBox listBox, ReadOpts theOptions, SymbologyMap[] map)
        {
            // put each symbology into the check box,
            // checking it as needed.
            for (var i = 0; i < map.Length; i++)
            {
                listBox.Items.Add(map[i]);
                if ((theOptions.Symbology & map[i].Symbology) != 0)
                {
                    listBox.SetItemChecked(i, true);
                }
            }
        }

        /// <summary>
        /// Generic for checking/unchecking all options in a Checked List Box
        /// </summary>
        /// <param name="listBox">The list box.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        private void CheckUncheckAllListItems(CheckedListBox listBox, bool status)
        {
            for (var i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetItemChecked(i, status);
            }
        }

        /// <summary>
        /// Check all sybmology items
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSelectAllSymbologies_Click(object sender, EventArgs e)
        {
            CheckUncheckAllListItems(_barcodeSymbologyList, true);
        }

        /// <summary>
        /// Uncheck all symbology items
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClearSymbologies_Click(object sender, EventArgs e)
        {
            CheckUncheckAllListItems(_barcodeSymbologyList, false);
        }

        // Look up the string value of a given symbology
        private string SymbologyToString(Symbologies sym, SymbologyMap[] map)
        {
            foreach (var t in map)
            {
                if (sym == t.Symbology)
                {
                    return t.SymbologyName;
                }
            }

            return "Unknown";
        }

        // Respond to a file open
        private void OpenButton_Click(object sender, EventArgs e)
        {
            // try to locate images folder
            var imagesFolder = Application.ExecutablePath;

            // we assume we are running under the DotImage install folder
            var pos = imagesFolder.IndexOf("DotImage ", StringComparison.Ordinal);
            if (pos != -1)
            {
                imagesFolder = imagesFolder.Substring(0, imagesFolder.IndexOf(@"\", pos, StringComparison.Ordinal)) + @"\Images\Barcodes";
            }

            // use this folder as starting point
            _openFileDialog.InitialDirectory = imagesFolder;

            // Filter on the available, licensed decoders
            _openFileDialog.Filter = WinDemoHelperMethods.CreateDialogFilter(true);
            
            if (_openFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                _tmpImg = new AtalaImage(_openFileDialog.FileName);

                // Loads the image into the viewer - applying the desired morphology if needed
                UpdateMorphology();
                //// workspaceViewer.Open(openFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show(Resources.Barcoder_OpenButton_UnableToLoad + _openFileDialog.FileName + @".");
                _imageLoaded = false;
                return;
            }

            _imageLoaded = true;

            // check if its OK start a recognize at this point
            ValidateRecognize(0, 0);
            _finalResults = null;
        }

        // user has de/selected a barcode Symbology set
        private void BarcodeSymbologyList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var index = e.Index;
            var cs = e.NewValue;
            var map = (SymbologyMap)_barcodeSymbologyList.Items[index];
            if (map != null)
            {
                if (cs == CheckState.Checked)
                {
                    _options.Symbology |= map.Symbology;
                }
                else
                {
                    _options.Symbology &= ~map.Symbology;
                }

                // this callback semantics are off in the sense that the controls
                // count of checked items isn't updated until after all
                // callbacks have been hit, which means that we can't tell
                // how many are checked without adding a delta in.
                // We'll let Validate handle the delta.
                ValidateRecognize(cs == CheckState.Checked ? 1 : -1, 0);
            }
        }

        // user has de/selected a scan direction
        private void ScanDirectionList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var index = e.Index;
            var cs = e.NewValue;
            var map = (ScanDirectionMap)_scanDirectionList.Items[index];
            if (map != null)
            {
                if (cs == CheckState.Checked)
                {
                    _options.Direction |= map.Direction;
                }
                else
                {
                    _options.Direction &= ~map.Direction;
                }

                // this callback semantics are off in the sense that the controls
                // count of checked items isn't updated until after all
                // callbacks have been hit, which means that we can't tell
                // how many are checked without adding a delta in.
                // We'll let Validate handle the delta.
                ValidateRecognize(0, cs == CheckState.Checked ? 1 : -1);
            }
        }

        // Make sure that it is OK to proceed with recognition
        private void ValidateRecognize(int symbologyDeltaOnChangedCheck, int scanDirectionDeltaOnChangedCheck)
        {
            // To be ready for recognition, an image must be loaded,
            // a symbology must be selected and a scan direction
            // must be selected.
            _recognizeButton.Enabled = _imageLoaded &&
                _barcodeSymbologyList.CheckedItems.Count + symbologyDeltaOnChangedCheck != 0 &&
                _scanDirectionList.CheckedItems.Count + scanDirectionDeltaOnChangedCheck != 0;
        }

        private void ScanInterval_ValueChanged(object sender, EventArgs e)
        {
            // give feedback on the current value of the control
            _scanIntervalLabel.Text = _scanInterval.Value.ToString();
            if (_options != null)
                _options.ScanInterval = _scanInterval.Value;
        }

        private void ExpectedBarCodes_ValueChanged(object sender, EventArgs e)
        {
            // give feedback on the current value of the control
            _expectedBarcodesLabel.Text = _expectedBarCodes.Value.ToString();
            _options.ScanBarsToRead = _expectedBarCodes.Value;
        }

        private void WorkspaceViewer_Paint(object sender, PaintEventArgs e)
        {
            // paint the frames on top of the existing image

            // no results, nothing to do.
            if (_finalResults == null)
            {
                return;
            }

            DrawResultsPolygons(e.Graphics, _finalResults);
        }

        private void DrawResultsPolygons(Graphics g, BarCode[] results)
        {
            var penBlue = new Pen(Color.Blue, 4);
            var penOrange = new Pen(Color.Orange, 1);
            var zoom = _workspaceViewer.Zoom;
            foreach (var t in results)
            {
                // handle the bounding rectangles
                if (_showBoundingRects.Checked)
                {
                    var r = t.BoundingRect;

                    // the bounding rects that come back can have negative values in
                    // some cases.
                    if (r.Width < 0)
                    {
                        r.X += r.Width;
                        r.Width = -r.Width;
                    }

                    if (r.Height < 0)
                    {
                        r.Y += r.Height;
                        r.Height = -r.Height;
                    }

                    // scale and offset the bounding rect.
                    r.X = (int)(r.X * zoom);
                    r.Y = (int)(r.Y * zoom);
                    r.Width = (int)(r.Width * zoom);
                    r.Height = (int)(r.Height * zoom);
                    r.Offset(_workspaceViewer.ImagePosition);
                    g.DrawRectangle(penBlue, r);
                }

                // handle the bounding boxes (quadrilaterals)
                if (_showBoundingBoxes.Checked)
                {
                    var p1 = ScaleAndOffset(t.StartEdgePoints[0], zoom, _workspaceViewer.ImagePosition);
                    var p2 = ScaleAndOffset(t.StartEdgePoints[1], zoom, _workspaceViewer.ImagePosition);
                    var p3 = ScaleAndOffset(t.EndEdgePoints[1], zoom, _workspaceViewer.ImagePosition);
                    var p4 = ScaleAndOffset(t.EndEdgePoints[0], zoom, _workspaceViewer.ImagePosition);
                    g.DrawLine(penOrange, p1, p2);
                    g.DrawLine(penOrange, p2, p3);
                    g.DrawLine(penOrange, p3, p4);
                    g.DrawLine(penOrange, p4, p1);
                }
            }

            penBlue.Dispose();
            penOrange.Dispose();
        }

        private void ShrinkToFit_CheckedChanged(object sender, EventArgs e)
        {
            if (_shrinkToFit.Checked)
            {
                _workspaceViewer.AutoZoom = AutoZoomMode.BestFitShrinkOnly;
            }
            else
            {
                _workspaceViewer.AutoZoom = AutoZoomMode.None;
                _workspaceViewer.Zoom = 1.0;
            }
        }

        private void ShowBoundingBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (_finalResults != null)
            {
                _workspaceViewer.Invalidate();
            }
        }

        private void ShowBoundingRects_CheckedChanged(object sender, EventArgs e)
        {
            if (_finalResults != null)
            {
                _workspaceViewer.Invalidate();
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            var aboutBox = new About("About Atalasoft DotImage Barcode Reader Demo",
                "DotImage Barcode Reader Demo");
            aboutBox.Description = @"The Barcode Reader Demo demonstrates how to read a barcode from an image.  This demo should be used to gain a basic understanding of how the DotImage Barcode recognition functions.  The demo allows you to set options, such as barcode types, scan directions, scan interval and the number of expected barcodes.  If you are having trouble recognizing a barcode, this demo may help to see why.  Requires DotImage and DotImage BarcodeReader.";
            aboutBox.ShowDialog();
        }

        private void StatusBox_DoubleClick(object sender, EventArgs e)
        {
            var resForm = new ResultForm(_statusBox.Text);
            resForm.ShowDialog();
        }

        #region Morphology Selection
        private void BtnMorphoNone_CheckedChanged(object sender, EventArgs e)
        {
            if (_btnMorphoNone.Checked)
            {
                UpdateMorphology("None");
            }
        }

        private void BtnMorphoDilate_CheckedChanged(object sender, EventArgs e)
        {
            if (_btnMorphoDilate.Checked)
            {
                UpdateMorphology("Dilate");
            }
        }

        private void BtnMorphoErode_CheckedChanged(object sender, EventArgs e)
        {
            if (_btnMorphoErode.Checked)
            {
                UpdateMorphology("Erode");
            }
        }

        private void UpdateMorphology()
        {
            // call the default
            UpdateMorphology("None");
            _btnMorphoNone.Checked = true;
        }

        private void UpdateMorphology(string mode)
        {
            // load fresh COPY of the image
            if (_tmpImg != null)
            {
                _workspaceViewer.Image = (AtalaImage)_tmpImg.Clone();

                switch (mode)
                {
                    case "Dilate":
                        _workspaceViewer.ApplyCommand(new MorphoDocumentCommand() { Mode = MorphoDocumentMode.Dilation, ApplyToAnyPixelFormat = true });
                        break;
                    case "Erode":
                        _workspaceViewer.ApplyCommand(new MorphoDocumentCommand() { Mode = MorphoDocumentMode.Erosion, ApplyToAnyPixelFormat = true });
                        break;
                }
            }
            else
            {
                MessageBox.Show(Resources.Barcoder_UpdateMorphology_SelectFile);
            }
        }

        #endregion Morphology Selection

        #region Nested classes
        // private class for mapping internal symbology names into
        // the user interface
        private class SymbologyMap
        {
            public SymbologyMap(string name, Symbologies sym)
            {
                SymbologyName = name;
                Symbology = sym;
            }

            public string SymbologyName { get; private set; }

            public Symbologies Symbology { get; private set; }

            // ToString is vital - it allows this object to live transparently
            // in a ListBox and have its SymbologyName displayed.
            public override string ToString() 
            {
                return SymbologyName;
            }
        }

        // private class for mapping internal scan directions into
        // the user interface
        private class ScanDirectionMap
        {
            public ScanDirectionMap(string name, Directions dir)
            {
                ScanDirectionName = name;
                Direction = dir;
            }

            public Directions Direction { get; private set; }

            // ReSharper disable once MemberCanBePrivate.Local - since class is private anyway; public is just as good and cleaner
            public string ScanDirectionName { get; private set; }

            // ToString is vital - it allows this object to live transparently
            // in a ListBox and have its ScanDirectionName displayed.
            public override string ToString()
            {
                return ScanDirectionName;
            }
        }

        #endregion
    }
}
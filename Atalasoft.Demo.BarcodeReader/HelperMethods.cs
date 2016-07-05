using System;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.CadCam;
using Atalasoft.Imaging.Codec.Dicom;
using Atalasoft.Imaging.Codec.IppJpeg;
using Atalasoft.Imaging.Codec.Jbig2;
using Atalasoft.Imaging.Codec.Jpeg2000;
using Atalasoft.Imaging.Codec.Pdf;
using Atalasoft.Imaging.Codec.Tiff;

namespace BarcodeDemo
{
	public struct ImageFormatInformation
	{
		public string Filter;
		public string Description;
		public ImageEncoder Encoder;
		public ImageDecoder Decoder;

		public ImageFormatInformation(ImageEncoder encoder, string description, string filter)
		{
			this.Encoder = encoder;
			this.Decoder = null;
			this.Description = description;
			this.Filter = filter;
		}

		public ImageFormatInformation(ImageDecoder decoder, string description, string filter)
		{
			this.Decoder = decoder;
			this.Encoder = null;
			this.Description = description;
			this.Filter = filter;
		}
	}

	/// <summary>
	/// A collection of static methods.
	/// </summary>
	public sealed class HelperMethods
	{
		private static System.Collections.ArrayList _decoderImageFormats = new System.Collections.ArrayList();
		private static System.Collections.ArrayList _encoderImageFormats = new System.Collections.ArrayList();

		static HelperMethods()
		{
			// Decoders
			_decoderImageFormats.Add(new ImageFormatInformation(new JpegDecoder(), "Joint Photographic Experts Group (*.jpg)", "*.jpg"));
			_decoderImageFormats.Add(new ImageFormatInformation(new PngDecoder(),  "Portable Network Graphic (*.png)", "*.png"));
			_decoderImageFormats.Add(new ImageFormatInformation(new TiffDecoder(), "Tagged Image File (*.tif, *.tiff)", "*.tif;*.tiff"));
			_decoderImageFormats.Add(new ImageFormatInformation(new PcxDecoder(),  "ZSoft PaintBrush (*.pcx)", "*.pcx"));
			_decoderImageFormats.Add(new ImageFormatInformation(new TgaDecoder(),  "Truevision Targa (*.tga)", "*.tga"));
			_decoderImageFormats.Add(new ImageFormatInformation(new BmpDecoder(),  "Windows Bitmap (*.bmp)", "*.bmp"));
			_decoderImageFormats.Add(new ImageFormatInformation(new WmfDecoder(),  "Windows Meta File (*.wmf)", "*.wmf"));
			_decoderImageFormats.Add(new ImageFormatInformation(new EmfDecoder(),  "Enhanced Windows Meta File (*.emf)", "*.emf"));
			_decoderImageFormats.Add(new ImageFormatInformation(new PsdDecoder(),  "Adobe (tm) Photoshop format (*.psd)", "*.psd"));
			_decoderImageFormats.Add(new ImageFormatInformation(new WbmpDecoder(), "Wireless Bitmap (*.wbmp)", "*.wbmp"));
			_decoderImageFormats.Add(new ImageFormatInformation(new GifDecoder(),  "Graphics Interchange Format (*.gif)", "*.gif"));
			_decoderImageFormats.Add(new ImageFormatInformation(new TlaDecoder(),  "Smaller Animals TLA (*.tla)", "*.tla"));
			_decoderImageFormats.Add(new ImageFormatInformation(new PcdDecoder(),  "Kodak (tm) PhotoCD (*.pcd)", "*.pcd"));			
			_decoderImageFormats.Add(new ImageFormatInformation(new RawDecoder(),  "RAW Images", "*.dcr;*.dng;*.eff;*.mrw;*.nef;*.orf;*.pef;*.raf;*.srf;*.x3f;*.crw;*.cr2;*.tif;*.ppm"));

			try {_decoderImageFormats.Add(new ImageFormatInformation(new DwgDecoder(),  "Cad/Cam (*.dwg *.dxf)", "*.dwg;*.dxf"));}
			catch (AtalasoftLicenseException) {}

			try {_decoderImageFormats.Add(new ImageFormatInformation(new Jb2Decoder(),  "JBIG2 (*.jb2)", "*.jb2"));}
			catch (AtalasoftLicenseException) {}
			
			try {_decoderImageFormats.Add(new ImageFormatInformation(new PdfDecoder(),  "PDF (*.pdf)", "*.pdf"));}
			catch (AtalasoftLicenseException){}

			try	{_decoderImageFormats.Add(new ImageFormatInformation(new Jp2Decoder(),  "JPEG2000 (*.jpf *.jp2, *.jpc *.j2c *.j2k)", "*.jpf;*.jp2;*.jpc;*.j2c;*.j2k"));}
			catch (AtalasoftLicenseException) {}
			
			try {_decoderImageFormats.Add(new ImageFormatInformation(new DjVuDecoder(), "DjVu (*.djvu)", "*.djvu"));}
			catch (AtalasoftLicenseException) {}
			
			try {_decoderImageFormats.Add(new ImageFormatInformation(new DicomDecoder(), "Dicom (*.dcm *.dce)", "*.dcm;*.dce"));}		
			catch (AtalasoftLicenseException){}

			// Encoders
			_encoderImageFormats.Add(new ImageFormatInformation(new JpegEncoder(), "Joint Photographic Experts Group (*.jpg)", "*.jpg"));
			_encoderImageFormats.Add(new ImageFormatInformation(new PngEncoder(),  "Portable Network Graphic (*.png)", "*.png"));
			_encoderImageFormats.Add(new ImageFormatInformation(new TiffEncoder(), "Tagged Image File (*.tif, *.tiff)", "*.tif;*.tiff"));
			_encoderImageFormats.Add(new ImageFormatInformation(new PcxEncoder(),  "ZSoft PaintBrush (*.pcx)", "*.pcx"));
			_encoderImageFormats.Add(new ImageFormatInformation(new TgaEncoder(),  "Truevision Targa (*.tga)", "*.tga"));
			_encoderImageFormats.Add(new ImageFormatInformation(new BmpEncoder(),  "Windows Bitmap (*.bmp)", "*.bmp"));
			_encoderImageFormats.Add(new ImageFormatInformation(new WmfEncoder(),  "Windows Meta File (*.wmf)", "*.wmf"));
			_encoderImageFormats.Add(new ImageFormatInformation(new EmfEncoder(),  "Enhanced Windows Meta File (*.emf)", "*.emf"));
			_encoderImageFormats.Add(new ImageFormatInformation(new PsdEncoder(),  "Adobe (tm) Photoshop format (*.psd)", "*.psd"));
			_encoderImageFormats.Add(new ImageFormatInformation(new WbmpEncoder(), "Wireless Bitmap (*.wbmp)", "*.wbmp"));
			_encoderImageFormats.Add(new ImageFormatInformation(new GifEncoder(),  "Graphics Interchange Format (*.gif)", "*.gif"));
			_encoderImageFormats.Add(new ImageFormatInformation(new TlaEncoder(),  "Smaller Animals TLA (*.tla)", "*.tla"));

			try {_encoderImageFormats.Add(new ImageFormatInformation(new Jb2Encoder(),  "JBIG2 (*.jb2)", "*.jb2"));}
			catch (AtalasoftLicenseException) {}
			
			try {_encoderImageFormats.Add(new ImageFormatInformation(new PdfEncoder(),  "PDF (*.pdf)", "*.pdf"));}
			catch (AtalasoftLicenseException){}

			try	{_encoderImageFormats.Add(new ImageFormatInformation(new Jp2Encoder(),  "JPEG2000 (*.jpf *.jp2, *.jpc *.j2c *.j2k)", "*.jpf;*.jp2;*.jpc;*.j2c;*.j2k"));}
			catch (AtalasoftLicenseException) {}				
		}
		
		/// <summary>
		/// Creates the filter string for open and save dialogs.
		/// </summary>
		/// <param name="isOpenDialog">Set to true if this filter is for an open dialog.</param>
		/// <returns>The filter string for an open or save dialog.</returns>
		public static string CreateDialogFilter(bool isOpenDialog)
		{
			System.Text.StringBuilder filter = new System.Text.StringBuilder();
			
			if (isOpenDialog)
			{
				// All supported formats
				filter.Append("All Supported Images|");
				foreach (ImageFormatInformation info in _decoderImageFormats)
					filter.Append(info.Filter + ";");
			
				// Individual format filter
				foreach (ImageFormatInformation info in _decoderImageFormats)
				{
					if (filter.Length > 0) 
						filter.Append("|");
					filter.Append(info.Description + "|" + info.Filter);
				}

				// Add all files filter, this will cover, e.g. Dicom files without extension
				filter.Append("|All files (*.*)|*.*");
			}
			else
			{
				// All supported formats
				filter.Append("All Supported Formats|");
				foreach (ImageFormatInformation info in _encoderImageFormats)
					filter.Append(info.Filter + ";");

				// Individual format filter
				foreach (ImageFormatInformation info in _encoderImageFormats)
				{
					if (filter.Length > 0)
						filter.Append("|");
					filter.Append(info.Description + "|" + info.Filter);
				}

				filter.Append("|Animated GIF (*.gif)|*.gif");
			}

			return filter.ToString();
		}

		public static void PopulateDecoders(DecoderCollection col)
		{
			foreach (ImageFormatInformation info in _decoderImageFormats)
				if (!col.Contains(info.Decoder))
					col.Add(info.Decoder);
		}
	}
}

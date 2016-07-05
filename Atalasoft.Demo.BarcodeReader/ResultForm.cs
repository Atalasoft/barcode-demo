// ------------------------------------------------------------------------------------
// <copyright file="ResultForm.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System.Windows.Forms;
using Atalasoft.Demo.BarcodeReader.Properties;

namespace Atalasoft.Demo.BarcodeReader
{
    /// <summary>
    /// Represents results form.
    /// </summary>
    internal partial class ResultForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultForm"/> class.
        /// </summary>
        /// <param name="resultText">The result text.</param>
        public ResultForm(string resultText)
        {
            InitializeComponent();
            textBox1.Text = resultText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultForm"/> class.
        /// </summary>
        public ResultForm() : this (Resources.ResultForm_NoResults)
        { }
    }
}
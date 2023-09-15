using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardTool
{
    /// <summary>
    /// Main Form of the Clipboard Tool.
    /// </summary>
    public partial class MainForm : Form
    {

        private static readonly String AUTOFOMRAT = "Auto";

        /// <summary>
        /// Timer to update shown clipboard content.
        /// </summary>
        private Timer _timer = new Timer();

        public MainForm()
        {
            InitializeComponent();

            // Initialize items in the combobox
            _cbx_format.Items.Add(AUTOFOMRAT);
            _cbx_format.Items.Add(DataFormats.Html);
            _cbx_format.Items.Add(DataFormats.UnicodeText);
            _cbx_format.SelectedIndex = 0;

            // Initialize timer
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();

        }

        /// <summary>
        /// Event handler for the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            var clipboardData = Clipboard.GetDataObject();
            if (_cbx_format.Text == AUTOFOMRAT)
                _txtBox_clipboardContent.Text = ReadAsStringByDefault(clipboardData);
            else if (_cbx_format.Text == DataFormats.Html)
                _txtBox_clipboardContent.Text = ReadAsFormat(clipboardData, DataFormats.Html);
            else if (_cbx_format.Text == DataFormats.UnicodeText)
                _txtBox_clipboardContent.Text = (String)clipboardData.GetData(DataFormats.UnicodeText);
        }

        /// <summary>
        /// Read the clipboard data as string.
        /// </summary>
        /// <param name="clipboardData"></param>
        /// <returns></returns>
        private static String ReadAsStringByDefault(IDataObject clipboardData)
        {
            if (clipboardData.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                //CSV
                return (String)clipboardData.GetData(DataFormats.UnicodeText);
            }
            else if (clipboardData.GetDataPresent(DataFormats.Html))
            {
                //HTML
                return (String)clipboardData.GetData(DataFormats.Html);
            }
            else if (clipboardData.GetDataPresent(DataFormats.UnicodeText))
            {
                //UnicodeText as a kind of fallback
                return (String)clipboardData.GetData(DataFormats.UnicodeText);
            }

            // Empty String for data which can not handled as UnicodeText
            return "";

        }

        /// <summary>
        /// Read the clipboard data as string for a specific format.
        /// </summary>
        /// <param name="clipboardData"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        private static String ReadAsFormat(IDataObject clipboardData, String format)
        {
            if (clipboardData.GetDataPresent(format))
            {
                return (String)clipboardData.GetData(format);
            }
            return "";
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _btn_readFromClipboard_Click(object sender, EventArgs e)
        {
            _txtBox_clipboardContent.Text = 
                ReadAsString(Clipboard.GetDataObject());
        }

        private static String ReadAsString(IDataObject clipboardData)
        {
            if (clipboardData.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                return (String) clipboardData.GetData(DataFormats.UnicodeText);
            }
            else if (clipboardData.GetDataPresent(DataFormats.Html))
            {
                return (String) clipboardData.GetData(DataFormats.Html);
            }
            else if(clipboardData.GetDataPresent(DataFormats.UnicodeText))
            {
                //UnicodeText as a kind of fallback
                return (String) clipboardData.GetData(DataFormats.UnicodeText);
            }

            // Empty String for data which can not handled as UnicodeText
            return "";

        }
    }
}

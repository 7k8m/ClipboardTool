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

        private Timer _timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _txtBox_clipboardContent.Text = ReadAsString(Clipboard.GetDataObject());
        }

        /// <summary>
        /// Read the clipboard data as string.
        /// </summary>
        /// <param name="clipboardData"></param>
        /// <returns></returns>
        private static String ReadAsString(IDataObject clipboardData)
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClipboardTool
{
    /// <summary>
    /// Main Form of the Clipboard Tool.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Text for Auto Format in the combobox.
        /// </summary>
        private static readonly String AUTOFOMRAT = "Auto";

        /// <summary>
        /// Timer to catch misseed update of clipboard content.
        /// </summary>
        private Timer _timer = new Timer();

        #region Constants and methods for customizing System Menu
        // P/Invoke constants
        private const uint WM_SYSCOMMAND = 0x112;
        private const uint MF_STRING = 0x0;
        private const uint MF_SEPARATOR = 0x800;
        private const uint MF_CHECKED = 0x00000008;
        private const uint MF_UNCHECKED = 0x00000000;

        // P/Invoke declarations
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, uint uFlags, UIntPtr uIDNewItem, string lpNewItem);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int CheckMenuItem(IntPtr hMenu, uint uIDCheckItem, uint uCheck);
        // ID for the AlwaysTop item on the system menu
        private const uint SYSMENU_ALWAYS_TOP = 0x1;
        #endregion

        #region Constants and method for catch clipboard update       
        public const int WM_CLIPBOARDUPDATE = 0x031D;
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);
        #endregion

        public MainForm()
        {
            InitializeComponent();

            // Initialize items in the combobox
            _cbx_format.Items.Add(AUTOFOMRAT);
            _cbx_format.Items.Add(DataFormats.Html);
            _cbx_format.Items.Add(DataFormats.UnicodeText);
            _cbx_format.SelectedIndex = 0;
            
            UpdateClipboardContentDisp();
            _txtBox_clipboardContent.Select(0, 0);//Supress unintentional selection of text

            AddClipboardFormatListener(Handle);

            // Initialize timer
            _timer.Interval = 10000; // Low frequency because timer just catches missed clipboard updates.
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();
        }

        #region Touching WIN32 API
        protected override void OnHandleCreated(EventArgs e)
        {
            // Get a handle to a copy of this form's system (window) menu
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);
            // Add a separator
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);
            // Add the Always top menu item
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ALWAYS_TOP, "&Always top");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ALWAYS_TOP))
            {
                this.TopMost = !this.TopMost;
                CheckMenuItem(
                    GetSystemMenu(this.Handle, false),
                    SYSMENU_ALWAYS_TOP,
                    this.TopMost ? MF_CHECKED : MF_UNCHECKED
                );
            }
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                UpdateClipboardContentDisp();
            }
        }
        #endregion

        /// <summary>
        /// Event handler for the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateClipboardContentDisp();
        }

        private void UpdateClipboardContentDisp()
        {
            var clipboardData = Clipboard.GetDataObject();
            if (_cbx_format.Text == AUTOFOMRAT)// Read content of clipboard depending on content of clipboard
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

        private void _cbx_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClipboardContentDisp();
        }
    }
}

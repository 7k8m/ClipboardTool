namespace ClipboardTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _txtBox_clipboardContent = new System.Windows.Forms.TextBox();
            _cbx_format = new System.Windows.Forms.ComboBox();
            _lbl_readAs = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // _txtBox_clipboardContent
            // 
            _txtBox_clipboardContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _txtBox_clipboardContent.Location = new System.Drawing.Point(7, 6);
            _txtBox_clipboardContent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            _txtBox_clipboardContent.Multiline = true;
            _txtBox_clipboardContent.Name = "_txtBox_clipboardContent";
            _txtBox_clipboardContent.ReadOnly = true;
            _txtBox_clipboardContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            _txtBox_clipboardContent.Size = new System.Drawing.Size(414, 169);
            _txtBox_clipboardContent.TabIndex = 0;
            // 
            // _cbx_format
            // 
            _cbx_format.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _cbx_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbx_format.FormattingEnabled = true;
            _cbx_format.Location = new System.Drawing.Point(289, 186);
            _cbx_format.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            _cbx_format.Name = "_cbx_format";
            _cbx_format.Size = new System.Drawing.Size(132, 23);
            _cbx_format.TabIndex = 1;
            _cbx_format.SelectedIndexChanged += _cbx_format_SelectedIndexChanged;
            // 
            // _lbl_readAs
            // 
            _lbl_readAs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _lbl_readAs.AutoSize = true;
            _lbl_readAs.Location = new System.Drawing.Point(230, 189);
            _lbl_readAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            _lbl_readAs.Name = "_lbl_readAs";
            _lbl_readAs.Size = new System.Drawing.Size(55, 15);
            _lbl_readAs.TabIndex = 2;
            _lbl_readAs.Text = "Read As :";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 220);
            Controls.Add(_lbl_readAs);
            Controls.Add(_cbx_format);
            Controls.Add(_txtBox_clipboardContent);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "ClipboardTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox _txtBox_clipboardContent;
        private System.Windows.Forms.ComboBox _cbx_format;
        private System.Windows.Forms.Label _lbl_readAs;
    }
}


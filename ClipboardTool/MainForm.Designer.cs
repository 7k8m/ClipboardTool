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
            _btn_readFromClipboard = new System.Windows.Forms.Button();
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
            _txtBox_clipboardContent.Size = new System.Drawing.Size(419, 164);
            _txtBox_clipboardContent.TabIndex = 0;
            // 
            // _btn_readFromClipboard
            // 
            _btn_readFromClipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            _btn_readFromClipboard.Location = new System.Drawing.Point(12, 178);
            _btn_readFromClipboard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            _btn_readFromClipboard.Name = "_btn_readFromClipboard";
            _btn_readFromClipboard.Size = new System.Drawing.Size(173, 22);
            _btn_readFromClipboard.TabIndex = 1;
            _btn_readFromClipboard.Text = "Read From Clipboard";
            _btn_readFromClipboard.UseVisualStyleBackColor = true;
            _btn_readFromClipboard.Click += _btn_readFromClipboard_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(431, 211);
            Controls.Add(_btn_readFromClipboard);
            Controls.Add(_txtBox_clipboardContent);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "ClipboardTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox _txtBox_clipboardContent;
        private System.Windows.Forms.Button _btn_readFromClipboard;
    }
}


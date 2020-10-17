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
            this._txtBox_clipboardContent = new System.Windows.Forms.TextBox();
            this._btn_readFromClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtBox_clipboardContent
            // 
            this._txtBox_clipboardContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtBox_clipboardContent.Location = new System.Drawing.Point(13, 13);
            this._txtBox_clipboardContent.Multiline = true;
            this._txtBox_clipboardContent.Name = "_txtBox_clipboardContent";
            this._txtBox_clipboardContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtBox_clipboardContent.Size = new System.Drawing.Size(775, 345);
            this._txtBox_clipboardContent.TabIndex = 0;
            // 
            // _btn_readFromClipboard
            // 
            this._btn_readFromClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btn_readFromClipboard.Location = new System.Drawing.Point(22, 380);
            this._btn_readFromClipboard.Name = "_btn_readFromClipboard";
            this._btn_readFromClipboard.Size = new System.Drawing.Size(321, 46);
            this._btn_readFromClipboard.TabIndex = 1;
            this._btn_readFromClipboard.Text = "Read From Clipboard";
            this._btn_readFromClipboard.UseVisualStyleBackColor = true;
            this._btn_readFromClipboard.Click += new System.EventHandler(this._btn_readFromClipboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btn_readFromClipboard);
            this.Controls.Add(this._txtBox_clipboardContent);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBox_clipboardContent;
        private System.Windows.Forms.Button _btn_readFromClipboard;
    }
}


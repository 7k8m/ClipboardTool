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
            SuspendLayout();
            // 
            // _txtBox_clipboardContent
            // 
            _txtBox_clipboardContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _txtBox_clipboardContent.Location = new System.Drawing.Point(13, 13);
            _txtBox_clipboardContent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            _txtBox_clipboardContent.Multiline = true;
            _txtBox_clipboardContent.Name = "_txtBox_clipboardContent";
            _txtBox_clipboardContent.ReadOnly = true;
            _txtBox_clipboardContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            _txtBox_clipboardContent.Size = new System.Drawing.Size(775, 420);
            _txtBox_clipboardContent.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(_txtBox_clipboardContent);
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "MainForm";
            Text = "ClipboardTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox _txtBox_clipboardContent;
    }
}


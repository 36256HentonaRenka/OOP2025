namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            tbUrl = new TextBox();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            btReturn = new Button();
            btNext = new Button();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(758, 8);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(136, 33);
            btRssGet.TabIndex = 0;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // tbUrl
            // 
            tbUrl.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbUrl.Location = new Point(206, 8);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(546, 33);
            tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 15;
            lbTitles.Location = new Point(12, 47);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(882, 274);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            // 
            // webView21
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(12, 327);
            wvRssLink.Name = "webView21";
            wvRssLink.Size = new Size(882, 325);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            // 
            // btReturn
            // 
            btReturn.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReturn.Location = new Point(21, 8);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(75, 33);
            btReturn.TabIndex = 4;
            btReturn.Text = "戻る";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // btNext
            // 
            btNext.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNext.Location = new Point(102, 7);
            btNext.Name = "btNext";
            btNext.Size = new Size(98, 33);
            btNext.TabIndex = 5;
            btNext.Text = "進む";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 655);
            Controls.Add(btNext);
            Controls.Add(btReturn);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(tbUrl);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "Rssリーダー";
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRssGet;
        private TextBox tbUrl;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button btReturn;
        private Button btNext;
    }
}

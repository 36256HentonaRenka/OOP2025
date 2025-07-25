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
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            btGoBack = new Button();
            btGoFoward = new Button();
            cbRss = new ComboBox();
            btFavorite = new Button();
            tbFavorite = new TextBox();
            btDelete = new Button();
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
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 15;
            lbTitles.Location = new Point(12, 107);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(882, 274);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(12, 387);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(882, 265);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            wvRssLink.SourceChanged += wvRssLink_SourceChanged;
            // 
            // btGoBack
            // 
            btGoBack.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoBack.Location = new Point(12, 8);
            btGoBack.Name = "btGoBack";
            btGoBack.Size = new Size(75, 33);
            btGoBack.TabIndex = 4;
            btGoBack.Text = "戻る";
            btGoBack.UseVisualStyleBackColor = true;
            btGoBack.Click += btGoBack_Click;
            // 
            // btGoFoward
            // 
            btGoFoward.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoFoward.Location = new Point(93, 7);
            btGoFoward.Name = "btGoFoward";
            btGoFoward.Size = new Size(98, 33);
            btGoFoward.TabIndex = 5;
            btGoFoward.Text = "進む";
            btGoFoward.UseVisualStyleBackColor = true;
            btGoFoward.Click += btGoFoward_Click;
            // 
            // cbRss
            // 
            cbRss.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbRss.FormattingEnabled = true;
            cbRss.Location = new Point(206, 7);
            cbRss.Name = "cbRss";
            cbRss.Size = new Size(546, 33);
            cbRss.TabIndex = 6;
            // 
            // btFavorite
            // 
            btFavorite.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btFavorite.Location = new Point(424, 48);
            btFavorite.Name = "btFavorite";
            btFavorite.Size = new Size(121, 34);
            btFavorite.TabIndex = 7;
            btFavorite.Text = "お気に入り登録";
            btFavorite.UseVisualStyleBackColor = true;
            btFavorite.Click += btFavorite_Click;
            // 
            // tbFavorite
            // 
            tbFavorite.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbFavorite.Location = new Point(12, 54);
            tbFavorite.Name = "tbFavorite";
            tbFavorite.Size = new Size(406, 25);
            tbFavorite.TabIndex = 8;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDelete.Location = new Point(758, 45);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(123, 34);
            btDelete.TabIndex = 9;
            btDelete.Text = "お気に入り削除";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 655);
            Controls.Add(btDelete);
            Controls.Add(tbFavorite);
            Controls.Add(btFavorite);
            Controls.Add(cbRss);
            Controls.Add(btGoFoward);
            Controls.Add(btGoBack);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "Rssリーダー";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button btGoBack;
        private Button btGoFoward;
        private ComboBox cbRss;
        private Button btFavorite;
        private TextBox tbFavorite;
        private Button btDelete;
    }
}

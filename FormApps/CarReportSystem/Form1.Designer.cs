﻿namespace CarReportSystem {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpDate = new DateTimePicker();
            cbAuthor = new ComboBox();
            groupBox1 = new GroupBox();
            rbImport = new RadioButton();
            rbOther = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNIssan = new RadioButton();
            rbToyota = new RadioButton();
            cbCarName = new ComboBox();
            tbReport = new TextBox();
            dgvRecord = new DataGridView();
            pbPicture = new PictureBox();
            btPicOpen = new Button();
            btRecordAdd = new Button();
            btRecordDelete = new Button();
            btPicDelete = new Button();
            btRecordModify = new Button();
            ofdPickFileOpen = new OpenFileDialog();
            btNewRecord = new Button();
            ssMessageArea = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ssMessageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(2, 190);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "メーカー";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(440, 35);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 0;
            label2.Text = "画像";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(-5, 108);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(19, 271);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(77, 418);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(15, 526);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(-2, 356);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 0;
            label7.Text = "レポート";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.Location = new Point(19, 38);
            label8.Name = "label8";
            label8.Size = new Size(62, 32);
            label8.TabIndex = 0;
            label8.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(108, 36);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 35);
            dtpDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(108, 102);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(200, 38);
            cbAuthor.TabIndex = 2;
            cbAuthor.SelectedIndexChanged += cbAuthor_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNIssan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(108, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 62);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(6, 34);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 5;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(73, 34);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 4;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(176, 14);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 14);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 2;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNIssan
            // 
            rbNIssan.AutoSize = true;
            rbNIssan.Location = new Point(62, 14);
            rbNIssan.Name = "rbNIssan";
            rbNIssan.Size = new Size(49, 19);
            rbNIssan.TabIndex = 1;
            rbNIssan.TabStop = true;
            rbNIssan.Text = "日産";
            rbNIssan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 14);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(108, 271);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(200, 38);
            cbCarName.TabIndex = 4;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(108, 356);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(358, 143);
            tbReport.TabIndex = 5;
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.AllowUserToDeleteRows = false;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(108, 526);
            dgvRecord.MultiSelect = false;
            dgvRecord.Name = "dgvRecord";
            dgvRecord.ReadOnly = true;
            dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecord.Size = new Size(688, 163);
            dgvRecord.TabIndex = 6;
            dgvRecord.CellContentClick += dgvRecord_CellContentClick;
            dgvRecord.Click += dgvRecord_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(440, 70);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(362, 272);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // btPicOpen
            // 
            btPicOpen.FlatStyle = FlatStyle.Flat;
            btPicOpen.Location = new Point(630, 45);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 8;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btRecordAdd
            // 
            btRecordAdd.FlatStyle = FlatStyle.Flat;
            btRecordAdd.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordAdd.Location = new Point(486, 418);
            btRecordAdd.Name = "btRecordAdd";
            btRecordAdd.Size = new Size(84, 61);
            btRecordAdd.TabIndex = 8;
            btRecordAdd.Text = "追加";
            btRecordAdd.UseVisualStyleBackColor = true;
            btRecordAdd.Click += btRecordAdd_Click;
            // 
            // btRecordDelete
            // 
            btRecordDelete.FlatStyle = FlatStyle.Flat;
            btRecordDelete.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordDelete.Location = new Point(669, 418);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(91, 61);
            btRecordDelete.TabIndex = 8;
            btRecordDelete.Text = "削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            btRecordDelete.Click += btRecordDelete_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.FlatStyle = FlatStyle.Flat;
            btPicDelete.Location = new Point(711, 44);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 8;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // btRecordModify
            // 
            btRecordModify.FlatStyle = FlatStyle.Flat;
            btRecordModify.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordModify.Location = new Point(576, 418);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(87, 61);
            btRecordModify.TabIndex = 8;
            btRecordModify.Text = "修正";
            btRecordModify.UseVisualStyleBackColor = true;
            btRecordModify.Click += btRecordModify_Click;
            // 
            // ofdPickFileOpen
            // 
            ofdPickFileOpen.FileName = "openFileDialog1";
            // 
            // btNewRecord
            // 
            btNewRecord.FlatStyle = FlatStyle.Flat;
            btNewRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewRecord.Location = new Point(332, 38);
            btNewRecord.Name = "btNewRecord";
            btNewRecord.Size = new Size(102, 43);
            btNewRecord.TabIndex = 9;
            btNewRecord.Text = "新規入力";
            btNewRecord.UseVisualStyleBackColor = true;
            btNewRecord.Click += btNewRecord_Click;
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessageArea.Location = new Point(0, 694);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(831, 22);
            ssMessageArea.TabIndex = 10;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(831, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, tsmiExit });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(140, 22);
            開くToolStripMenuItem.Text = "開く…";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(140, 22);
            保存ToolStripMenuItem.Text = "保存…";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(137, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(140, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(137, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmiExit.Size = new Size(140, 22);
            tsmiExit.Text = "終了";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(155, 22);
            tsmiAbout.Text = "このアプリについて";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 716);
            Controls.Add(ssMessageArea);
            Controls.Add(menuStrip1);
            Controls.Add(btNewRecord);
            Controls.Add(btPicDelete);
            Controls.Add(btRecordModify);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordAdd);
            Controls.Add(btPicOpen);
            Controls.Add(pbPicture);
            Controls.Add(dgvRecord);
            Controls.Add(tbReport);
            Controls.Add(cbCarName);
            Controls.Add(groupBox1);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試験レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpDate;
        private ComboBox cbAuthor;
        private GroupBox groupBox1;
        private RadioButton rbNIssan;
        private RadioButton rbToyota;
        private RadioButton rbImport;
        private RadioButton rbOther;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private ComboBox cbCarName;
        private TextBox tbReport;
        private DataGridView dgvRecord;
        private PictureBox pbPicture;
        private Button btPicOpen;
        private Button btRecordAdd;
        private Button btRecordDelete;
        private Button btPicDelete;
        private Button btRecordModify;
        private OpenFileDialog ofdPickFileOpen;
        private Button btNewRecord;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ColorDialog cdColor;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFileOpen;
    }
}

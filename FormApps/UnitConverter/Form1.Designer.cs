namespace UnitConverter {
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
            tbAfterConversion = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(218, 45);
            label1.TabIndex = 0;
            label1.Text = "距離換算アプリ";
            // 
            // tbAfterConversion
            // 
            tbAfterConversion.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbAfterConversion.Location = new Point(139, 256);
            tbAfterConversion.Name = "tbAfterConversion";
            tbAfterConversion.Size = new Size(100, 39);
            tbAfterConversion.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textBox1.Location = new Point(139, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(139, 186);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 2;
            button1.Text = "変換";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 365);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tbAfterConversion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbAfterConversion;
        private TextBox textBox1;
        private Button button1;
    }
}

namespace SeleniumLab
{
    partial class Form1
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
            this.TestBtn = new System.Windows.Forms.Button();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.folderLabel = new System.Windows.Forms.Label();
            this.checkBox1920_1080 = new System.Windows.Forms.CheckBox();
            this.checkBox1366_768 = new System.Windows.Forms.CheckBox();
            this.checkBox1280_720 = new System.Windows.Forms.CheckBox();
            this.checkBox3840_2160 = new System.Windows.Forms.CheckBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.checkBox_useCustome = new System.Windows.Forms.CheckBox();
            this.isSilent = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(49, 184);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(461, 53);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "Протестировать";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // linkBox
            // 
            this.linkBox.AllowDrop = true;
            this.linkBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkBox.Location = new System.Drawing.Point(49, 12);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(461, 33);
            this.linkBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выбрать папку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folderLabel.Location = new System.Drawing.Point(157, 61);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(141, 21);
            this.folderLabel.TabIndex = 6;
            this.folderLabel.Text = "Папка не выбрана";
            // 
            // checkBox1920_1080
            // 
            this.checkBox1920_1080.AutoSize = true;
            this.checkBox1920_1080.Location = new System.Drawing.Point(49, 153);
            this.checkBox1920_1080.Name = "checkBox1920_1080";
            this.checkBox1920_1080.Size = new System.Drawing.Size(79, 19);
            this.checkBox1920_1080.TabIndex = 7;
            this.checkBox1920_1080.Text = "1920*1080";
            this.checkBox1920_1080.UseVisualStyleBackColor = true;
            // 
            // checkBox1366_768
            // 
            this.checkBox1366_768.AutoSize = true;
            this.checkBox1366_768.Location = new System.Drawing.Point(157, 121);
            this.checkBox1366_768.Name = "checkBox1366_768";
            this.checkBox1366_768.Size = new System.Drawing.Size(73, 19);
            this.checkBox1366_768.TabIndex = 8;
            this.checkBox1366_768.Text = "1368*768";
            this.checkBox1366_768.UseVisualStyleBackColor = true;
            // 
            // checkBox1280_720
            // 
            this.checkBox1280_720.AutoSize = true;
            this.checkBox1280_720.Location = new System.Drawing.Point(157, 153);
            this.checkBox1280_720.Name = "checkBox1280_720";
            this.checkBox1280_720.Size = new System.Drawing.Size(73, 19);
            this.checkBox1280_720.TabIndex = 9;
            this.checkBox1280_720.Text = "1280*720";
            this.checkBox1280_720.UseVisualStyleBackColor = true;
            // 
            // checkBox3840_2160
            // 
            this.checkBox3840_2160.AutoSize = true;
            this.checkBox3840_2160.Location = new System.Drawing.Point(49, 121);
            this.checkBox3840_2160.Name = "checkBox3840_2160";
            this.checkBox3840_2160.Size = new System.Drawing.Size(79, 19);
            this.checkBox3840_2160.TabIndex = 10;
            this.checkBox3840_2160.Text = "3840*2160";
            this.checkBox3840_2160.UseVisualStyleBackColor = true;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(319, 143);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(78, 23);
            this.textBox_width.TabIndex = 11;
            this.textBox_width.TextChanged += new System.EventHandler(this.textBox_width_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Высота";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(428, 143);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(77, 23);
            this.textBox_height.TabIndex = 13;
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox_useCustome
            // 
            this.checkBox_useCustome.AutoSize = true;
            this.checkBox_useCustome.Location = new System.Drawing.Point(319, 96);
            this.checkBox_useCustome.Name = "checkBox_useCustome";
            this.checkBox_useCustome.Size = new System.Drawing.Size(186, 19);
            this.checkBox_useCustome.TabIndex = 15;
            this.checkBox_useCustome.Text = "Использовать свои значения";
            this.checkBox_useCustome.UseVisualStyleBackColor = true;
            // 
            // isSilent
            // 
            this.isSilent.AutoSize = true;
            this.isSilent.Location = new System.Drawing.Point(48, 93);
            this.isSilent.Name = "isSilent";
            this.isSilent.Size = new System.Drawing.Size(100, 19);
            this.isSilent.TabIndex = 16;
            this.isSilent.Text = "Тихий режим";
            this.isSilent.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 250);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 282);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.isSilent);
            this.Controls.Add(this.checkBox_useCustome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.checkBox3840_2160);
            this.Controls.Add(this.checkBox1280_720);
            this.Controls.Add(this.checkBox1366_768);
            this.Controls.Add(this.checkBox1920_1080);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.TestBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TestBtn;
        private TextBox linkBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private Label folderLabel;
        private CheckBox checkBox1920_1080;
        private CheckBox checkBox1366_768;
        private CheckBox checkBox1280_720;
        private CheckBox checkBox3840_2160;
        private TextBox textBox_width;
        private Label label1;
        private Label label2;
        private TextBox textBox_height;
        private CheckBox checkBox_useCustome;
        private CheckBox isSilent;
        private ProgressBar progressBar1;
    }
}
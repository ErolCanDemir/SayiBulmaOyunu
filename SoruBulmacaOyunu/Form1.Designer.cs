namespace SoruBulmacaOyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_BasamakSayisi = new System.Windows.Forms.NumericUpDown();
            this.button_SayiUret = new System.Windows.Forms.Button();
            this.textBox_Onbinler = new System.Windows.Forms.TextBox();
            this.textBox_Binler = new System.Windows.Forms.TextBox();
            this.textBox_Yuzler = new System.Windows.Forms.TextBox();
            this.textBox_Onlar = new System.Windows.Forms.TextBox();
            this.textBox_Birler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button_Kontrol = new System.Windows.Forms.Button();
            this.radioButton_Tekrarli = new System.Windows.Forms.RadioButton();
            this.radioButton_Tekrarsiz = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_Hak = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BasamakSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basamak Sayısı Giriniz: ";
            // 
            // numericUpDown_BasamakSayisi
            // 
            this.numericUpDown_BasamakSayisi.Location = new System.Drawing.Point(167, 16);
            this.numericUpDown_BasamakSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_BasamakSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_BasamakSayisi.Name = "numericUpDown_BasamakSayisi";
            this.numericUpDown_BasamakSayisi.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_BasamakSayisi.TabIndex = 1;
            this.numericUpDown_BasamakSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button_SayiUret
            // 
            this.button_SayiUret.Location = new System.Drawing.Point(9, 139);
            this.button_SayiUret.Name = "button_SayiUret";
            this.button_SayiUret.Size = new System.Drawing.Size(246, 29);
            this.button_SayiUret.TabIndex = 2;
            this.button_SayiUret.Text = "Sayı Üret";
            this.button_SayiUret.UseVisualStyleBackColor = true;
            this.button_SayiUret.Click += new System.EventHandler(this.button_SayiUret_Click);
            // 
            // textBox_Onbinler
            // 
            this.textBox_Onbinler.Location = new System.Drawing.Point(35, 57);
            this.textBox_Onbinler.MaxLength = 1;
            this.textBox_Onbinler.Name = "textBox_Onbinler";
            this.textBox_Onbinler.Size = new System.Drawing.Size(52, 22);
            this.textBox_Onbinler.TabIndex = 3;
            this.textBox_Onbinler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Binler
            // 
            this.textBox_Binler.Location = new System.Drawing.Point(93, 57);
            this.textBox_Binler.MaxLength = 1;
            this.textBox_Binler.Name = "textBox_Binler";
            this.textBox_Binler.Size = new System.Drawing.Size(52, 22);
            this.textBox_Binler.TabIndex = 3;
            this.textBox_Binler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Yuzler
            // 
            this.textBox_Yuzler.Location = new System.Drawing.Point(151, 57);
            this.textBox_Yuzler.MaxLength = 1;
            this.textBox_Yuzler.Name = "textBox_Yuzler";
            this.textBox_Yuzler.Size = new System.Drawing.Size(52, 22);
            this.textBox_Yuzler.TabIndex = 3;
            this.textBox_Yuzler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Onlar
            // 
            this.textBox_Onlar.Location = new System.Drawing.Point(209, 57);
            this.textBox_Onlar.MaxLength = 1;
            this.textBox_Onlar.Name = "textBox_Onlar";
            this.textBox_Onlar.Size = new System.Drawing.Size(52, 22);
            this.textBox_Onlar.TabIndex = 3;
            this.textBox_Onlar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Birler
            // 
            this.textBox_Birler.Location = new System.Drawing.Point(267, 57);
            this.textBox_Birler.MaxLength = 1;
            this.textBox_Birler.Name = "textBox_Birler";
            this.textBox_Birler.Size = new System.Drawing.Size(52, 22);
            this.textBox_Birler.TabIndex = 3;
            this.textBox_Birler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 10);
            this.label2.TabIndex = 4;
            this.label2.Text = "         ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(93, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 10);
            this.label3.TabIndex = 4;
            this.label3.Text = "         ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(151, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 10);
            this.label4.TabIndex = 4;
            this.label4.Text = "         ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(209, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 10);
            this.label5.TabIndex = 4;
            this.label5.Text = "         ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(267, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 10);
            this.label6.TabIndex = 4;
            this.label6.Text = "         ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Adınızı Giriniz : ";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ad.Location = new System.Drawing.Point(116, 12);
            this.textBox_Ad.Multiline = true;
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(111, 20);
            this.textBox_Ad.TabIndex = 6;
            this.textBox_Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Baslat
            // 
            this.button_Baslat.Location = new System.Drawing.Point(9, 46);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(218, 31);
            this.button_Baslat.TabIndex = 7;
            this.button_Baslat.Text = "Başlat";
            this.button_Baslat.UseVisualStyleBackColor = true;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // button_Kontrol
            // 
            this.button_Kontrol.Location = new System.Drawing.Point(31, 100);
            this.button_Kontrol.Name = "button_Kontrol";
            this.button_Kontrol.Size = new System.Drawing.Size(288, 40);
            this.button_Kontrol.TabIndex = 9;
            this.button_Kontrol.Text = "Kontrol Et";
            this.button_Kontrol.UseVisualStyleBackColor = true;
            this.button_Kontrol.Click += new System.EventHandler(this.button_Kontrol_Click);
            // 
            // radioButton_Tekrarli
            // 
            this.radioButton_Tekrarli.AutoSize = true;
            this.radioButton_Tekrarli.Location = new System.Drawing.Point(167, 45);
            this.radioButton_Tekrarli.Name = "radioButton_Tekrarli";
            this.radioButton_Tekrarli.Size = new System.Drawing.Size(77, 21);
            this.radioButton_Tekrarli.TabIndex = 10;
            this.radioButton_Tekrarli.TabStop = true;
            this.radioButton_Tekrarli.Text = "Tekrarlı";
            this.radioButton_Tekrarli.UseVisualStyleBackColor = true;
            // 
            // radioButton_Tekrarsiz
            // 
            this.radioButton_Tekrarsiz.AutoSize = true;
            this.radioButton_Tekrarsiz.Location = new System.Drawing.Point(167, 70);
            this.radioButton_Tekrarsiz.Name = "radioButton_Tekrarsiz";
            this.radioButton_Tekrarsiz.Size = new System.Drawing.Size(88, 21);
            this.radioButton_Tekrarsiz.TabIndex = 11;
            this.radioButton_Tekrarsiz.TabStop = true;
            this.radioButton_Tekrarsiz.Text = "Tekrarsız";
            this.radioButton_Tekrarsiz.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // numericUpDown_Hak
            // 
            this.numericUpDown_Hak.Location = new System.Drawing.Point(167, 100);
            this.numericUpDown_Hak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Hak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Hak.Name = "numericUpDown_Hak";
            this.numericUpDown_Hak.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_Hak.TabIndex = 15;
            this.numericUpDown_Hak.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_Ad);
            this.panel1.Controls.Add(this.button_Baslat);
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 100);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown_BasamakSayisi);
            this.panel2.Controls.Add(this.numericUpDown_Hak);
            this.panel2.Controls.Add(this.radioButton_Tekrarli);
            this.panel2.Controls.Add(this.radioButton_Tekrarsiz);
            this.panel2.Controls.Add(this.button_SayiUret);
            this.panel2.Location = new System.Drawing.Point(25, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 190);
            this.panel2.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Hakkınızı Seçiniz :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sayı Türünü Seçiniz :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(577, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 70);
            this.panel3.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Hak :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Süre :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.textBox_Onbinler);
            this.panel4.Controls.Add(this.textBox_Binler);
            this.panel4.Controls.Add(this.textBox_Yuzler);
            this.panel4.Controls.Add(this.textBox_Onlar);
            this.panel4.Controls.Add(this.button_Kontrol);
            this.panel4.Controls.Add(this.textBox_Birler);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(304, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 159);
            this.panel4.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(298, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Aşağıdaki Kutucuklardan Sayıyı Tahmin Ediniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bilgi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Soru Bulmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BasamakSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_BasamakSayisi;
        private System.Windows.Forms.Button button_SayiUret;
        private System.Windows.Forms.TextBox textBox_Onbinler;
        private System.Windows.Forms.TextBox textBox_Binler;
        private System.Windows.Forms.TextBox textBox_Yuzler;
        private System.Windows.Forms.TextBox textBox_Onlar;
        private System.Windows.Forms.TextBox textBox_Birler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button_Kontrol;
        private System.Windows.Forms.RadioButton radioButton_Tekrarli;
        private System.Windows.Forms.RadioButton radioButton_Tekrarsiz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}


namespace Monty_Hall_Problemi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.kapi1 = new System.Windows.Forms.PictureBox();
            this.kapi2 = new System.Windows.Forms.PictureBox();
            this.kapiSayac = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.kararSecenek = new System.Windows.Forms.CheckBox();
            this.denemeSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kazanilanKeciKutu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butonDene = new System.Windows.Forms.Button();
            this.kazanilanArabaKutu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kapi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapiSayac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kapi1
            // 
            this.kapi1.Image = global::Monty_Hall_Problemi.Properties.Resources.kapi;
            this.kapi1.Location = new System.Drawing.Point(47, 28);
            this.kapi1.Name = "kapi1";
            this.kapi1.Size = new System.Drawing.Size(203, 372);
            this.kapi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapi1.TabIndex = 0;
            this.kapi1.TabStop = false;
            this.kapi1.Visible = false;
            // 
            // kapi2
            // 
            this.kapi2.Image = global::Monty_Hall_Problemi.Properties.Resources.kapi;
            this.kapi2.Location = new System.Drawing.Point(256, 28);
            this.kapi2.Name = "kapi2";
            this.kapi2.Size = new System.Drawing.Size(203, 372);
            this.kapi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapi2.TabIndex = 2;
            this.kapi2.TabStop = false;
            this.kapi2.Visible = false;
            // 
            // kapiSayac
            // 
            this.kapiSayac.BackColor = System.Drawing.SystemColors.Control;
            this.kapiSayac.Location = new System.Drawing.Point(284, 34);
            this.kapiSayac.Name = "kapiSayac";
            this.kapiSayac.Size = new System.Drawing.Size(120, 38);
            this.kapiSayac.TabIndex = 3;
            this.kapiSayac.ValueChanged += new System.EventHandler(this.kapiSayac_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kapı Sayısı :";
            // 
            // kararSecenek
            // 
            this.kararSecenek.AutoSize = true;
            this.kararSecenek.BackColor = System.Drawing.SystemColors.Control;
            this.kararSecenek.Location = new System.Drawing.Point(12, 93);
            this.kararSecenek.Name = "kararSecenek";
            this.kararSecenek.Size = new System.Drawing.Size(303, 36);
            this.kararSecenek.TabIndex = 6;
            this.kararSecenek.Text = "İlk karar değiştirilsin";
            this.kararSecenek.UseVisualStyleBackColor = false;
            // 
            // denemeSayi
            // 
            this.denemeSayi.Location = new System.Drawing.Point(6, 159);
            this.denemeSayi.Name = "denemeSayi";
            this.denemeSayi.Size = new System.Drawing.Size(203, 38);
            this.denemeSayi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(221, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "kez denensin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kazanilanKeciKutu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butonDene);
            this.groupBox1.Controls.Add(this.kazanilanArabaKutu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kapiSayac);
            this.groupBox1.Controls.Add(this.denemeSayi);
            this.groupBox1.Controls.Add(this.kararSecenek);
            this.groupBox1.Location = new System.Drawing.Point(383, 610);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 341);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kazanilanKeciKutu
            // 
            this.kazanilanKeciKutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kazanilanKeciKutu.Location = new System.Drawing.Point(855, 153);
            this.kazanilanKeciKutu.Multiline = true;
            this.kazanilanKeciKutu.Name = "kazanilanKeciKutu";
            this.kazanilanKeciKutu.Size = new System.Drawing.Size(179, 38);
            this.kazanilanKeciKutu.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kazanılan keçi sayısı :";
            // 
            // butonDene
            // 
            this.butonDene.Location = new System.Drawing.Point(129, 255);
            this.butonDene.Name = "butonDene";
            this.butonDene.Size = new System.Drawing.Size(197, 57);
            this.butonDene.TabIndex = 9;
            this.butonDene.Text = "DENE";
            this.butonDene.UseVisualStyleBackColor = true;
            this.butonDene.Click += new System.EventHandler(this.butonDene_Click);
            // 
            // kazanilanArabaKutu
            // 
            this.kazanilanArabaKutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kazanilanArabaKutu.Location = new System.Drawing.Point(855, 37);
            this.kazanilanArabaKutu.Multiline = true;
            this.kazanilanArabaKutu.Name = "kazanilanArabaKutu";
            this.kazanilanArabaKutu.Size = new System.Drawing.Size(179, 38);
            this.kazanilanArabaKutu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kazanılan araba sayısı :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monty_Hall_Problemi.Properties.Resources.arkaPlan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2187, 1057);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kapi2);
            this.Controls.Add(this.kapi1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Monty Hall Problemi // Mert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapiSayac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kapi1;
        private System.Windows.Forms.PictureBox kapi2;
        private System.Windows.Forms.NumericUpDown kapiSayac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox kararSecenek;
        private System.Windows.Forms.TextBox denemeSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butonDene;
        private System.Windows.Forms.TextBox kazanilanKeciKutu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kazanilanArabaKutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
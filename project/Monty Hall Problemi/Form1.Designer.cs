namespace Monty_Hall_Problemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oynaButon = new System.Windows.Forms.Button();
            this.istatistikButon = new System.Windows.Forms.Button();
            this.creditsButon = new System.Windows.Forms.Button();
            this.gorunmezButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monty_Hall_Problemi.Properties.Resources.anaMenu21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1698, 1053);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // oynaButon
            // 
            this.oynaButon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.oynaButon.Location = new System.Drawing.Point(722, 707);
            this.oynaButon.Name = "oynaButon";
            this.oynaButon.Size = new System.Drawing.Size(308, 63);
            this.oynaButon.TabIndex = 1;
            this.oynaButon.Text = "Oyunu Oyna";
            this.oynaButon.UseVisualStyleBackColor = true;
            this.oynaButon.Click += new System.EventHandler(this.oynaButon_Click);
            // 
            // istatistikButon
            // 
            this.istatistikButon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.istatistikButon.Location = new System.Drawing.Point(722, 806);
            this.istatistikButon.Name = "istatistikButon";
            this.istatistikButon.Size = new System.Drawing.Size(308, 63);
            this.istatistikButon.TabIndex = 2;
            this.istatistikButon.Text = "İstatistikleri Gör";
            this.istatistikButon.UseVisualStyleBackColor = true;
            this.istatistikButon.Click += new System.EventHandler(this.istatistikButon_Click);
            // 
            // creditsButon
            // 
            this.creditsButon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.creditsButon.Location = new System.Drawing.Point(722, 897);
            this.creditsButon.Name = "creditsButon";
            this.creditsButon.Size = new System.Drawing.Size(308, 63);
            this.creditsButon.TabIndex = 3;
            this.creditsButon.Text = "Credits";
            this.creditsButon.UseVisualStyleBackColor = true;
            this.creditsButon.Click += new System.EventHandler(this.creditsButon_Click);
            // 
            // gorunmezButon
            // 
            this.gorunmezButon.Location = new System.Drawing.Point(347, 30);
            this.gorunmezButon.Name = "gorunmezButon";
            this.gorunmezButon.Size = new System.Drawing.Size(340, 123);
            this.gorunmezButon.TabIndex = 4;
            this.gorunmezButon.Text = "BunuGörmemenGerekiyorGörürsenMerteSöyle";
            this.gorunmezButon.UseVisualStyleBackColor = true;
            this.gorunmezButon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1685, 1053);
            this.Controls.Add(this.gorunmezButon);
            this.Controls.Add(this.creditsButon);
            this.Controls.Add(this.istatistikButon);
            this.Controls.Add(this.oynaButon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monty Hall Problemi // Mert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button oynaButon;
        private System.Windows.Forms.Button istatistikButon;
        private System.Windows.Forms.Button creditsButon;
        private System.Windows.Forms.Button gorunmezButon;
    }
}


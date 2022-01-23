using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monty_Hall_Problemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rst = new Random();
        int secilenKapiNo = 3;
        int ArabaKapiNo;

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Size = new Size(648, 470);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Form1.AnaMenuX, Form1.AnaMenuY);
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tikAlgilama();
        }

        private void kapiAyarla()
        {
            ArabaKapiNo = rst.Next(0, 3);        
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            int acilacakKapiNo;
            do
            {
                acilacakKapiNo = rst.Next(0, 3);
            } while (acilacakKapiNo == secilenKapiNo || acilacakKapiNo == ArabaKapiNo);
            //MessageBox.Show(ArabaKapiNo + ". kapıda araba var ve " + acilacakKapiNo + ". kapı açıldı!");
            
            switch (acilacakKapiNo)
            {
                case 0:
                    {
                        keciKapi0.Visible = true;
                        break;
                    }
                case 1:
                    {
                        keciKapi1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        keciKapi2.Visible = true;
                        break;
                    }
            }
            secilenKapiNo = 4;
           
            


        }

        private void arabaKapi2_MouseDown(object sender, MouseEventArgs e)
        {           
            tikAlgilama();
        }

        private void tikAlgilama1()
        {
            Point imlecKord = System.Windows.Forms.Cursor.Position;
            MessageBox.Show(imlecKord.ToString());
            MessageBox.Show(this.Location.ToString());
        }

        private void tikAlgilama()
        {
            Point imlecKord = System.Windows.Forms.Cursor.Position;
            Point formKord = this.Location;

            imlecKord = new Point(imlecKord.X + 8 - formKord.X + 478, imlecKord.Y - 31 - formKord.Y + 245);
           

            if (secilenKapiNo == 3)
            {
                if (imlecKord.X >= 478 && imlecKord.X <= 603 && imlecKord.Y >= 334 && imlecKord.Y <= 632)
                {
                    kapi1SecildiCarpi.Visible = true;
                    secilenKapiNo = 0;
                    kapiAyarla();
                }
                else if (imlecKord.X >= 715 && imlecKord.X <= 870 && imlecKord.Y >= 334 && imlecKord.Y <= 602)
                {
                    kapi2SecildiCarpi.Visible = true;
                    secilenKapiNo = 1;
                    kapiAyarla();
                }
                else if (imlecKord.X >= 943 && imlecKord.X <= 1098 && imlecKord.Y >= 334 && imlecKord.Y <= 604)
                {
                    kapi3SecildiCarpi.Visible = true;
                    secilenKapiNo = 2;
                    kapiAyarla();
                }
            }
            else if (secilenKapiNo == 4 && ( (imlecKord.X >= 478 && imlecKord.X <= 603 && imlecKord.Y >= 334 && imlecKord.Y <= 632) || (imlecKord.X >= 715 && imlecKord.X <= 870 && imlecKord.Y >= 334 && imlecKord.Y <= 602) || (imlecKord.X >= 943 && imlecKord.X <= 1098 && imlecKord.Y >= 334 && imlecKord.Y <= 604)) )
            {
                switch (ArabaKapiNo)
                {
                    case 0:
                        {
                            arabaKapi0.Visible = true;
                            kapi1SecildiCarpi.Visible = false;
                            keciKapi1.Visible = true;
                            keciKapi2.Visible = true;
                            break;
                        }
                    case 1:
                        {
                            arabaKapi1.Visible = true;
                            kapi2SecildiCarpi.Visible = false;
                            keciKapi2.Visible = true;
                            keciKapi0.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            arabaKapi2.Visible = true;
                            kapi3SecildiCarpi.Visible = false;
                            keciKapi1.Visible = true;
                            keciKapi0.Visible = true;
                            break;
                        }
                }
                kapi1SecildiCarpi.Visible = false;
                kapi2SecildiCarpi.Visible = false;
                kapi3SecildiCarpi.Visible = false;

                if (imlecKord.X >= 478 && imlecKord.X <= 603 && imlecKord.Y >= 334 && imlecKord.Y <= 632)
                {
                    if (ArabaKapiNo == 0)
                    {                                           
                        MessageBox.Show("Tebrikler, doğru tahmin!");
                    }
                    else
                    {
                        MessageBox.Show("Maalesef, yanlış tahmin!");
                    }
                    secilenKapiNo = 5;
                }
                else if (imlecKord.X >= 715 && imlecKord.X <= 870 && imlecKord.Y >= 334 && imlecKord.Y <= 602)
                {
                    if (ArabaKapiNo == 1)
                    {                                         
                        MessageBox.Show("Tebrikler, doğru tahmin!");
                    }
                    else
                    {
                        MessageBox.Show("Maalesef, yanlış tahmin!");
                    }
                    secilenKapiNo = 5;
                }
                else if (imlecKord.X >= 943 && imlecKord.X <= 1098 && imlecKord.Y >= 334 && imlecKord.Y <= 604)
                {
                    if (ArabaKapiNo == 2)
                    {                                          
                        MessageBox.Show("Tebrikler, doğru tahmin!");
                   }
                    else
                    {
                        MessageBox.Show("Maalesef, yanlış tahmin!");
                    }
                    secilenKapiNo = 5;
                }
                if (MessageBox.Show("Bir daha oynamak ister misiniz?", "Monty Hall Problemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kapi1SecildiCarpi.Visible = false;
                    kapi2SecildiCarpi.Visible = false;
                    kapi3SecildiCarpi.Visible = false;

                    keciKapi0.Visible = false;
                    keciKapi1.Visible = false;
                    keciKapi2.Visible = false;

                    arabaKapi0.Visible = false;
                    arabaKapi1.Visible = false;
                    arabaKapi2.Visible = false;
                    ArabaKapiNo = 0;
                    secilenKapiNo = 3;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                }
                else
                {
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }

            }
        }

        private void arabaKapi0_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void keciKapi0_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void kapi1SecildiCarpi_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void kapi2SecildiCarpi_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void keciKapi1_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void arabaKapi1_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void kapi3SecildiCarpi_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void keciKapi2_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }

        private void arabaKapi2_Click(object sender, EventArgs e)
        {
            tikAlgilama();
        }
    }
}

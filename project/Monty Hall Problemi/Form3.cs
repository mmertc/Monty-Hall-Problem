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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        PictureBox[] kapilar = new PictureBox[99];
        Random rnd = new Random();

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Size = new Size(1000, 470);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Form1.AnaMenuX, Form1.AnaMenuY);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kapiSayac_ValueChanged(object sender, EventArgs e)
        {
            if (kapiSayac.Value < 0) kapiSayac.Value = 0;
            else if (kapiSayac.Value > 98) kapiSayac.Value = 98;

            for (int i = 0; i < kapilar.Length; i++)
            {               
                this.Controls.Remove(kapilar[i]);
            }

            for (int i = 0; i < (kapiSayac.Value); i++)
            {              
                int offset = i * (120 - (((Convert.ToInt32(kapiSayac.Value) * 4) < 90) ? (Convert.ToInt32(kapiSayac.Value) * 4) : 90));
                kapilar[i] = new PictureBox
                {
                    Name = ("kapi" + i).ToString(),
                    Size = new Size(100 - ((Convert.ToInt32(kapiSayac.Value) * 4) < 72 ? (Convert.ToInt32(kapiSayac.Value) * 4) : 72), 200 - (((Convert.ToInt32(kapiSayac.Value) * 8) < 144) ? (Convert.ToInt32(kapiSayac.Value) * 8) : 144)),
                    Location = new Point(((i > 30) ? ( (i > 61) ? ( (i > 92) ? 19 + offset - 1860 - 930 : 18 + offset - 1860) : 18 + offset - 930) : 18 + offset), ((i > 30) ? ( (i > 61) ? ( (i > 92) ? 12 + 54 + 54 + 54 : 12 + 54 + 54 ) :12 + 54): 12)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = Image.FromFile(Application.StartupPath + @"\kapi.png"),
                };
                this.Controls.Add(kapilar[i]);
            }            
            for (int i = (Convert.ToInt32(kapiSayac.Value)); i < kapilar.Length; i++)
            {
                this.Controls.Remove(kapilar[i]);
            }
          }

        private void butonDene_Click(object sender, EventArgs e)
        {
            int basariSayi = 0;


            try
            {
                int problem = (Convert.ToInt32(denemeSayi.Text) + 100 * 2);
            }
            catch
            {
                MessageBox.Show("Deneme sayısında giriş yok ya da geçersiz giriş!", "Hata!", MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < Convert.ToInt32(denemeSayi.Text); i++)
            {
                int secim = rnd.Next(0, Convert.ToInt32(kapiSayac.Value));
                int arabaNo = rnd.Next(0, Convert.ToInt32(kapiSayac.Value));

                if (!kararSecenek.Checked)
                {
                    if (secim == arabaNo)
                    {
                        basariSayi++;
                        continue;
                    }
                }
                else
                {
                    if (secim == arabaNo)
                    {
                        continue;
                    }
                    else if (secim != arabaNo)
                    {
                        basariSayi++;
                        continue;
                    }

                }
            }


            kazanilanArabaKutu.Text = basariSayi.ToString();
            kazanilanKeciKutu.Text = (Convert.ToInt32(denemeSayi.Text) - basariSayi).ToString();








            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}

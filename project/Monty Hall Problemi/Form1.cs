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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public int AnaMenuX;
        static public int AnaMenuY;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(648, 470);
            gorunmezButon.Select();
        }

        private void creditsButon_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Bana bu ödevi veren Adnan Hocama teşekkür ediyorum. -Mustafa Mert Çetin", "Monty Hall Problemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = true;
        }

        private void oynaButon_Click(object sender, EventArgs e)
        {
            AnaMenuX = this.Location.X;
            AnaMenuY = this.Location.Y;
            Form2 frm2 = new Monty_Hall_Problemi.Form2();
            this.Visible = false;
            frm2.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void istatistikButon_Click(object sender, EventArgs e)
        {
            AnaMenuX = this.Location.X;
            AnaMenuY = this.Location.Y;
            Form3 frm3 = new Form3();
            frm3.Visible = true;
            this.Visible = false;
        }
    }
}

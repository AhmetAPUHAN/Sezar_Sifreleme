using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri=txtVeri.Text;
            char[] karekterler=veri.ToCharArray();
            foreach(char c in karekterler)
            {
                txtSifreliVeri.Text +=Convert.ToChar( c + 3).ToString();

            }



        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = txtSifreliVeri.Text;
            char[] karekterler = sifre.ToCharArray();   
            foreach(char c in karekterler)
            {
                txtVeri.Text += Convert.ToChar(c - 3).ToString();

            }
        }
    }
}

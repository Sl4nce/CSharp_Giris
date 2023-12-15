using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=textBox1.Text;
            string soyad=textBox2.Text;
            string meslekk = textBox4.Text;
            int yaş=Convert.ToInt32(textBox3.Text);
            Meslek meslek = new Meslek();
            meslek.isim(ad, soyad, meslekk, yaş);
        }
    }
}

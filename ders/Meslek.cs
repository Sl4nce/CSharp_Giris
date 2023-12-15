using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders
{
    internal class Meslek
    {
        public void isim(string ad,string soyad,string meslek,int yaş)
        {
            MessageBox.Show("İsim: " + ad + " Soyisim: " + soyad + " Meslek: " + meslek+" Yaş: "+yaş);
        }
        
    }
}

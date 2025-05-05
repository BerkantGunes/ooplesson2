using OOP__;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IKitaplar_[] kitaplar = new IKitaplar_[]
            {
                new Hiciv
                {
                    barkodNo = "0001",
                    kitapAd = "Tutunamayanlar",
                    Yazar = "Oğuz Atay"

                },
                new Komedi
                {
                    barkodNo = "0002",
                    kitapAd = "Evde Tek Başına",
                    Yazar = "Montogomery"

                },
                new Korku
                {
                     barkodNo = "0003",
                    kitapAd = "The Walking Dead",
                    Yazar = "Robert Kirkman"
                }
            };
           
           foreach (var kitap in kitaplar)
            {
                MessageBox.Show(kitap.kitapAd + " " + kitap.Yazar);
            }



        }
    }
}

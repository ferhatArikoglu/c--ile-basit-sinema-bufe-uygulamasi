using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar =0;
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + "TL";

            kasatutar += toplam;
            LblKasa.Text = kasatutar.ToString() + "TL";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtSu.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtMisir.Focus();
        }
    }
}

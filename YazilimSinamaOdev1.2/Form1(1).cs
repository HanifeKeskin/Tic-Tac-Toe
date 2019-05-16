using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaOdev1._2
{
    public partial class frmBaslangic : Form
    {
        public frmBaslangic()
        {
            InitializeComponent();
        }

        private void btnTekKisi_Click(object sender, EventArgs e)
        {
            txtPlayer1.Visible = true;
            txtPlayer2.Visible = true;
            txtPlayer2.Text = "COMPUTER";
            txtPlayer2.Enabled = false;
        }

        private void btnPlayXOX_Click(object sender, EventArgs e)
        {
            if (!txtPlayer1.Text.Equals("") && !txtPlayer2.Text.Equals(""))
            {
                frmOyunTek f1 = new frmOyunTek();
                frmOyunTek.setPlayerNames(txtPlayer1.Text, txtPlayer2.Text);
                f1.ShowDialog();
            }
            else
                MessageBox.Show("Please type a player name");

        }

        private void btnIki_Kisi_Click(object sender, EventArgs e)
        {
            txtPlayer1.Visible = true;
            txtPlayer2.Visible = true;
        }
    }
}

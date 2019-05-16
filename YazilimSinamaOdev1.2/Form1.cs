using SimpleTCP;
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
        SimpleTcpServer server;

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
            else if (txtPlayer1.Visible == false)
            {
                MessageBox.Show("Please Choose a Game Option");
            }
            else
                MessageBox.Show("Please type a player name");

        }

        private void btnIki_Kisi_Click(object sender, EventArgs e)
        {
            txtPlayer1.Visible = true;
            txtPlayer2.Visible = true;
        }
        private void btnAyniNet_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtHost.Visible = true;
            label2.Visible = true;
            txtPort.Visible = true;
            btnStart.Visible = true;
            btnStop.Visible = true;
        }

        private void frmBaslangic_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
          //  txtStatus.Invoke((MethodInvoker)delegate ()
            //{
              //  txtStatus.Text += e.MessageString;
                //e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            //});
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            // txtStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }

     
    }
}

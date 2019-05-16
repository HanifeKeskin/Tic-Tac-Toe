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
    public partial class frmOyunTek : Form
    {
        public frmOyunTek()
        {
            InitializeComponent();
        }

        private int sayi1 = 0;
        private int sayi2 = 0;
        bool turn = true; // true = x, false = o
        //bool iki_kisi = false;
        bool computer = false; //bilgisayara karşı mı yoksa iki farklı kişi mi
        bool win = false;
        int tcount = 0;
        static String player1, player2;

        public static void setPlayerNames (String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        private void button_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            if (b.Text.Equals(""))
            {
                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Gold;
                    lblPlay.Text = player2 + " Turn Now";
                    checkWinner();
                    tcount++;
                    if (!computer)
                    {
                        timerPlayer1.Stop();
                        timerPlayer2.Interval = 1000;
                        timerPlayer2.Start();
                    }
                }
               
            else
            {
                b.Text = "O";
                b.ForeColor = Color.DarkGreen;
                lblPlay.Text = player1 + " Turn Now";
                checkWinner();
                if (!computer)
                {
                    tcount++;
                        timerPlayer2.Stop();
                        timerPlayer1.Start();
                }
            }
                    turn = !turn;
                    if (tcount == 9 && win == false)
                    {
                    timerPlayer1.Stop();
                    timerPlayer2.Stop();
                    if (!computer)
                    {
                        if (sayi1 < sayi2)
                        {
                            lblPlay.Text = "X Win!";
                        }
                        else if (sayi2 < sayi1)
                        {
                            lblPlay.Text = "O Win!";
                        }
                        else
                        {
                            lblPlay.Text = "No Winner!";
                        }
                    }
                    else
                    {
                        lblPlay.Text = "No Winner";
                    }
                }
                    if (tcount != 9)
                    {
                        if (!turn && computer) //eğer bilgisayara karşı oynanıyorsa
                        {
                            computers_move();
                            tcount++;
                        }
                    }
            }
        }

        private void computers_move()
        {
                Button move = null;

                move = look_for_win_or_block("O"); //look for win
                if (move == null)
                {
                    move = look_for_win_or_block("X"); // look for block
                    if (move == null)
                    {
                        move = look_for_corner();
                        if (move == null)
                        {
                            move = look_for_open_space();
                        }
                    }
                }
            move.PerformClick();
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block: " + mark);
            //YATAY KONTROL
            if (btnA1.Text == mark && btnA2.Text == mark && btnA3.Text == "")
                return btnA3;
            if (btnA2.Text == mark && btnA3.Text == mark && btnA1.Text == "")
                return btnA1;
            if (btnA1.Text == mark && btnA3.Text == mark && btnA2.Text == "")
                return btnA2;
            if (btnB2.Text == mark && btnB3.Text == mark && btnB1.Text == "")
                return btnB1;
            if (btnB1.Text == mark && btnB3.Text == mark && btnB2.Text == "")
                return btnB2;
            if (btnB1.Text == mark && btnB2.Text == mark && btnB3.Text == "")
                return btnB3;
            if (btnC2.Text == mark && btnC3.Text == mark && btnC1.Text == "")
                return btnC1;
            if (btnC1.Text == mark && btnC3.Text == mark && btnC2.Text == "")
                return btnC2;
            if (btnC1.Text == mark && btnC2.Text == mark && btnC3.Text == "")
                return btnC3;
            //DİKEY KONTROL
            if (btnC1.Text == mark && btnB1.Text == mark && btnA1.Text == "")
                return btnA1;
            if (btnC1.Text == mark && btnA1.Text == mark && btnB1.Text == "")
                return btnB1;
            if (btnA1.Text == mark && btnB1.Text == mark && btnC1.Text == "")
                return btnC1;
            if (btnC2.Text == mark && btnB2.Text == mark && btnA2.Text == "")
                return btnA2;
            if (btnC2.Text == mark && btnA2.Text == mark && btnB2.Text == "")
                return btnB1;
            if (btnA2.Text == mark && btnB2.Text == mark && btnC2.Text == "")
                return btnC2;
            if (btnC3.Text == mark && btnB3.Text == mark && btnA3.Text == "")
                return btnA3;
            if (btnC3.Text == mark && btnA3.Text == mark && btnB3.Text == "")
                return btnB3;
            if (btnA3.Text == mark && btnB3.Text == mark && btnC3.Text == "")
                return btnC3;
            //ÇAPRAZ KONTROL
            if (btnC3.Text == mark && btnB3.Text == mark && btnA1.Text == "")
                return btnA1;
            if (btnC3.Text == mark && btnA1.Text == mark && btnB2.Text == "")
                return btnB2;
            if (btnA1.Text == mark && btnB2.Text == mark && btnC3.Text == "")
                return btnC3;
            if (btnC1.Text == mark && btnB2.Text == mark && btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == mark && btnA3.Text == mark && btnB2.Text == "")
                return btnB2;
            if (btnA3.Text == mark && btnB2.Text == mark && btnC1.Text == "")
                return btnC1;

            return null;
        }
        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (btnA1.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if(btnA3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if (btnC3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if (btnA1.Text == "")
                return btnA1;
            if (btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == "")
                return btnC1;
            if (btnC3.Text == "")
                return btnC3;
            else
            return null;
        } 

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            foreach(Control c in panel2.Controls)
            {
                Button b = (Button)c;
                if(b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private void checkWinner()
        {
            //yatay kontrol
            if (!btnA1.Text.Equals("") && (btnA1.Text.Equals(btnA2.Text)) && (btnA1.Text.Equals(btnA3.Text)))
            {
                winEffect(btnA1, btnA2, btnA3);
                win = true;
            }
            if (!btnB1.Text.Equals("") && (btnB1.Text.Equals(btnB2.Text)) && (btnB1.Text.Equals(btnB3.Text)))
            {
                winEffect(btnB1, btnB2, btnB3);
                win = true;
            }
            if (!btnC1.Text.Equals("") && (btnC1.Text.Equals(btnC2.Text)) && (btnC1.Text.Equals(btnC3.Text)))
            {
                winEffect(btnC1, btnC2, btnC3);
                win = true;
            }
            //dikey kontroller
            if (!btnA1.Text.Equals("") && (btnA1.Text.Equals(btnB1.Text)) && (btnA1.Text.Equals(btnC1.Text)))
            {
                winEffect(btnA1, btnB1, btnC1);
                win = true;
            }
            if (!btnA2.Text.Equals("") && (btnA2.Text.Equals(btnB2.Text)) && (btnA2.Text.Equals(btnC2.Text)))
            {
                winEffect(btnA2, btnB2, btnC2);
                win = true;
            }
            if (!btnA3.Text.Equals("") && (btnA3.Text.Equals(btnB3.Text)) && (btnA3.Text.Equals(btnC3.Text)))
            {
                winEffect(btnA3, btnB3, btnC3);
                win = true;
            }
            //çarpraz kontroller
            if (!btnA1.Text.Equals("") && (btnA1.Text.Equals(btnB2.Text)) && (btnA1.Text.Equals(btnC3.Text)))
            {
                winEffect(btnA1, btnB2, btnC3);
                win = true;
            }
            if (!btnA3.Text.Equals("") && (btnA3.Text.Equals(btnB2.Text)) && (btnA3.Text.Equals(btnC1.Text)))
            {
                winEffect(btnA3, btnB2, btnC1);
                win = true;
            }
        }
        
        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Maroon;
            b2.BackColor = Color.Maroon;
            b3.BackColor = Color.Maroon;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

            timerPlayer2.Stop();
            timerPlayer1.Stop();
            //kazandıktan sonra başka butona basamazsın
            disableButtons();
            if (b1.Text == "X")
                lblPlay.Text = lblPlayer1.Text + " Win!!";
            else
                lblPlay.Text = lblPlayer2.Text + "Win!";
        }

        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            sayi1 = sayi1 + 1;
            lblSayi1.Text = Convert.ToString(sayi1);
        }

        public void disableButtons()
        {
            //panel2 üzerindeki butonların enabled'ını false yap
                foreach (Control c in panel2.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
        }

        private void frmOyunTek_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
            if (player2 == "COMPUTER")
            {
                computer = true;
            }
            if (!computer)
            {
                lblSayi1.Visible = true;
                lblSayi2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                lblSayi1.Text = Convert.ToString(sayi1);
                lblSayi2.Text = Convert.ToString(sayi2);
                timerPlayer1.Interval = 1000;
                timerPlayer1.Start();
            }
            
        }

        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            sayi2 = sayi2 + 1;
            lblSayi2.Text = Convert.ToString(sayi2);
        }

        private void frmOyunTek_KeyDown(object sender, KeyEventArgs e)
        {
            if (turn)
            {
                if (e.KeyCode == Keys.Q)
                {
                    btnA1.PerformClick();
                }
                if (e.KeyCode == Keys.W)
                {
                    btnA2.PerformClick();
                }
                if (e.KeyCode == Keys.E)
                {
                    btnA3.PerformClick();
                }
                if (e.KeyCode == Keys.A)
                {
                    btnB1.PerformClick();
                }
                if (e.KeyCode == Keys.S)
                {
                    btnB2.PerformClick();
                }
                if (e.KeyCode == Keys.D)
                {
                    btnB3.PerformClick();
                }
                if (e.KeyCode == Keys.Z)
                {
                    btnC1.PerformClick();
                }
                if (e.KeyCode == Keys.X)
                {
                    btnC2.PerformClick();
                }
                if (e.KeyCode == Keys.C)
                {
                    btnC3.PerformClick();
                }
            }
            else
            {
                if (e.KeyCode == Keys.NumPad7)
                {
                    btnA1.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad8)
                {
                    btnA2.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad9)
                {
                    btnA3.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad4)
                {
                    btnB1.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad5)
                {
                    btnB2.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad6)
                {
                    btnB3.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    btnC1.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    btnC2.PerformClick();
                }
                if (e.KeyCode == Keys.NumPad3)
                {
                    btnC3.PerformClick();
                }
            }
            
        }

        private void btnTekNewGame_Click(object sender, EventArgs e)
        {
            tcount = 0;
            win = false;
            turn = true;
            lblPlay.Text = "Play Now";
            foreach (Control c in panel2.Controls)
            {
                Button b = (Button)c;
                b.Text = "";
                b.BackColor = Color.White;
                b.Enabled = true;
            }
            sayi1 = 0;
            lblSayi1.Text = Convert.ToString(sayi1);
            sayi2 = 0;
            lblSayi2.Text = Convert.ToString(sayi2);
        }
    }
}

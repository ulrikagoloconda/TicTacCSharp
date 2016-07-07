using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       private int turn = 0;
       private char c = 'X';
      private  char[][] modelBoard;
        

        public Form1()
        {
            InitializeComponent();
         
        }

     

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ett Tic Tac Toe i all sin enkelhet för att friska upp mina, Ulrika Golocondas, kunskaper i C#");
        }

        private void Lable_Click(object sender, EventArgs e)
        {
            ((Label)sender).Text = "" + c;
            ((Label)sender).Enabled = false;
           if(WinCheck())
            {
                MessageBox.Show(c + " har vunnit!");
            }
            turn++;
            if (turn >= 9)
            {
                MessageBox.Show("Ingen har vunnit!");
            }
            else
            {
                if (turn % 2 == 0)
                {
                    c = 'X';
                }
                else
                {
                    c = '0';
                }
            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).Text = "" + c;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Text = "";

        }

        private bool WinCheck() {
            bool returnBool = false;
         
           

            //Diagonalcheck
            if ((A1.Text == B2.Text && A1.Text == C3.Text && A1.Text.Length > 0) || (A3.Text == B2.Text && A3.Text == C1.Text && A3.Text.Length > 0))
            {
                returnBool = true;
            }


            //Vågchekc
            if ((A1.Text == A2.Text && A1.Text == A3.Text && A1.Text.Length >0) 
                || (B1.Text == B2.Text && B1.Text == B3.Text && B1.Text.Length > 0)
                || (C1.Text == C2.Text && C1.Text == C3.Text) && C1.Text.Length > 0)
            {
                returnBool = true;
            }


            //Höjdcheck
            if ((A1.Text == B1.Text && A1.Text == B1.Text && A1.Text == C1.Text && A1.Text.Length > 0)
                || (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text== C2.Text && A2.Text.Length > 0)
                || (A3.Text == B3.Text && A3.Text == B3.Text && A3.Text == C3.Text && A3.Text.Length > 0))
            {
                returnBool = true;
            }

            return returnBool; 
        }
    }
}

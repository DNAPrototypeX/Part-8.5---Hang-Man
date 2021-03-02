using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8._5___Hang_Man
{
    public partial class frmMain : Form
    {
        List<string> wordBank = new List<string>() {"bean", "aldworth", "maths", "bok choy",
            "hang man", "anti tank missile" };
        Random rng = new Random();
        string secretWord = "";
        string displayWord;
        string guessWord = "";
        int guessesUsed = 0;
        List<Image> images = new List<Image>() 
        {
            Properties.Resources.hangman_0, 
            Properties.Resources.hangman_1, 
            Properties.Resources.hangman_2,
            Properties.Resources.hangman_3, 
            Properties.Resources.hangman_4, 
            Properties.Resources.hangman_5
        };


        public void checkGuess(string guess)
        {
            if (secretWord.Contains(guess))
            {
                for (int i = 0; i <= secretWord.Length - 1; i ++)
                {
                    if (secretWord[i].ToString() == guess)
                    {
                        if (i != 0)
                        {
                            guessWord = guessWord.Insert(i, guess);
                            guessWord = guessWord.Remove(i + 1, 1);
                            displayWord = displayWord.Insert(i * 2, guess);
                            displayWord = displayWord.Remove((i * 2) + 1, 1);
                        }
                        else
                        {
                            guessWord = guessWord.Remove(0, 1);
                            guessWord = guessWord.Insert(0, guess);
                            displayWord = displayWord.Remove(0, 1);
                            displayWord = displayWord.Insert(0, guess);
                        }
                        
                    }                
                    
                }
            }           
            else
            {
                guessesUsed += 1;
                imgHangman.Image = images[guessesUsed];
            }
            lblDisplayWord.Text = displayWord;
        }
        public void checkWinLoss()
        {
            if (!displayWord.Contains("_"))
            {
                lblGuessesRemaining.Text = "You Win";
            }
            else if (displayWord.Contains("_") & guessesUsed == 5)
            {
                lblGuessesRemaining.Text = "You lost";
            }

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            secretWord = wordBank[rng.Next(6)];
            lblGuessesRemaining.Text = secretWord;
            for (int i = 0; i <= secretWord.Length - 1; i++)
            {
                guessWord += "_";
                if (secretWord[i].ToString() == " ")
                {
                    displayWord += "  ";
                }
                else
                {
                    displayWord += "_ ";
                }                
                lblDisplayWord.Text = displayWord;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            checkGuess("g");
            checkWinLoss();
            btnG.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            checkGuess("m");
            checkWinLoss();
            btnM.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            checkGuess("q");
            checkWinLoss();
            btnQ.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            checkGuess("n");
            checkWinLoss();
            btnN.Enabled = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            checkGuess("r");
            checkWinLoss();
            btnR.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            checkGuess("w");
            checkWinLoss();
            btnW.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            checkGuess("f");
            checkWinLoss();
            btnF.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            checkGuess("b");
            checkWinLoss();
            btnB.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            checkGuess("d");
            checkWinLoss();
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            checkGuess("e");
            checkWinLoss();
            btnE.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            checkGuess("v");
            checkWinLoss();
            btnV.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            checkGuess("s");
            checkWinLoss();
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            checkGuess("t");
            checkWinLoss();
            btnT.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            checkGuess("h");
            checkWinLoss();
            btnH.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            checkGuess("c");
            checkWinLoss();
            btnC.Enabled = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            checkGuess("a");
            checkWinLoss();
            btnA.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            checkGuess("y");
            checkWinLoss();
            btnY.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            checkGuess("j");
            checkWinLoss();
            btnJ.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            checkGuess("x");
            checkWinLoss();
            btnX.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            checkGuess("p");
            checkWinLoss();
            btnP.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            checkGuess("u");
            checkWinLoss();
            btnU.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            checkGuess("k");
            checkWinLoss();
            btnK.Enabled = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            checkGuess("z");
            checkWinLoss();
            btnZ.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            checkGuess("o");
            checkWinLoss();
            btnO.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            checkGuess("i");
            checkWinLoss();
            btnI.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            checkGuess("l");
            checkWinLoss();
            btnL.Enabled = false;
        }
    }
}

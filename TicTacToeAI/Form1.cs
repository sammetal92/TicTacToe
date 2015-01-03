using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAI
{
    public partial class Form1 : Form
    {
        public static Color c = new Color();
        public static Button[] buttons = new Button[9];
        public static string player = "", computer = "";
        private static int[,] Winners = new int[,]
				   {
						{0,1,2},
						{3,4,5},
						{6,7,8},
						{0,3,6},
						{1,4,7},
						{2,5,8},
						{0,4,8},
						{2,4,6}
				   };
        public Form1()
        {
            InitializeComponent();
        }

        public static int checkWin()
        {
            bool draw = true;
            foreach (Button b in buttons)
                if (b.Text == "")
                {
                    draw = false;
                    break;
                }

            for (int i = 0; i < 8; i++)
            {
                int a = Winners[i, 0], b = Winners[i, 1], c = Winners[i, 2];
                Button b1 = buttons[a], b2 = buttons[b], b3 = buttons[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "") continue;
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.LawnGreen;
                    b1.Font = b2.Font = b3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32F, System.Drawing.FontStyle.Italic & System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                    return (b1.Text == player ? 1 : 2);
                }
            }
            if (draw) return -1;
            else return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = top_left.BackColor;
            buttons[0] = top_left;
            buttons[1] = top_middle;
            buttons[2] = top_right;
            buttons[3] = middle_left;
            buttons[4] = middle_middle;
            buttons[5] = middle_right;
            buttons[6] = bottom_left;
            buttons[7] = bottom_middle;
            buttons[8] = bottom_right;
            gamePanel.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (x_Radio.Checked)
            {
                player = "X";
                computer = "O";
            }
            else
            {
                player = "O";
                computer = "X";
            }
            foreach (Control c in selectionPanel.Controls)
                if (c.Text != "Stop Game")
                    c.Enabled = false;
            stopButton.Enabled = true;
            gamePanel.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                b.Text = "";
                b.BackColor = c;
            }
            foreach (Control c in selectionPanel.Controls)
                if (c.Text != "Stop Game")
                    c.Enabled = true;
            stopButton.Enabled = false;
            gamePanel.Enabled = false;
        }

        private void gameButton_click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (player == "X")
                {
                    ((Button)sender).ForeColor = Color.Red;
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).ForeColor = Color.Blue;
                    ((Button)sender).Text = "O";
                }
                
                // CHECK FOR WIN //
                int winner = checkWin();
                if (winner > 0)
                {
                    if (winner == 1) MessageBox.Show("Player wins!");
                    else MessageBox.Show("Computer Wins!");
                    stopButton_Click(sender, e);
                    return;
                }
                else if (winner == -1)
                {
                    MessageBox.Show("Draw!");
                    stopButton_Click(sender, e);
                    return;
                }

                // COMPUTER'S TURN //
                Button b_to_mark = new Button();
                bool found = false;
                if (middle_middle.Text == "") b_to_mark = middle_middle;
                else
                {
                    for (int x = 0; x < 8; x += 3)
                    {
                        if (buttons[x].Text == player && buttons[x + 1].Text == player && buttons[x + 2].Text == "")
                        {
                            b_to_mark = buttons[x + 2];
                            found = true;
                            break;
                        }
                        else if (buttons[x].Text == player && buttons[x + 1].Text == "" && buttons[x + 2].Text == player)
                        {
                            b_to_mark = buttons[x + 1];
                            found = true;
                            break;
                        }
                        else if (buttons[x].Text == "" && buttons[x + 1].Text == player && buttons[x + 2].Text == player)
                        {
                            b_to_mark = buttons[x];
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            if (buttons[x].Text == player && buttons[x + 3].Text == player && buttons[x + 6].Text == "")
                            {
                                b_to_mark = buttons[x + 6];
                                found = true;
                                break;
                            }
                            else if (buttons[x].Text == player && buttons[x + 3].Text == "" && buttons[x + 6].Text == player)
                            {
                                b_to_mark = buttons[x + 3];
                                found = true;
                                break;
                            }
                            else if (buttons[x].Text == "" && buttons[x + 3].Text == player && buttons[x + 6].Text == player)
                            {
                                b_to_mark = buttons[x];
                                found = true;
                                break;
                            }
                        }

                        if (!found && buttons[0].Text == player && buttons[4].Text == player && buttons[8].Text == "")
                        {
                            b_to_mark = buttons[8];
                            found = true;
                        }
                        else if (!found && buttons[2].Text == player && buttons[4].Text == player && buttons[6].Text == "")
                        {
                            b_to_mark = buttons[6];
                            found = true;
                        }
                        else if (!found && buttons[8].Text == player && buttons[4].Text == player && buttons[0].Text == "")
                        {
                            b_to_mark = buttons[0];
                            found = true;
                        }
                        else if (!found && buttons[6].Text == player && buttons[4].Text == player && buttons[2].Text == "")
                        {
                            b_to_mark = buttons[2];
                            found = true;
                        }
                        else if (!found)
                        {
                            Random r = new Random();
                            do
                                b_to_mark = buttons[r.Next(9)];
                            while (b_to_mark.Text != "");
                            found = true;
                        }
                    }
                }
                if (computer == "X")
                {
                    b_to_mark.ForeColor = Color.Red;
                    b_to_mark.Text = "X";
                }
                else
                {
                    b_to_mark.ForeColor = Color.Blue;
                    b_to_mark.Text = "O";
                }

                winner = checkWin();
                if (winner > 0)
                {
                    if (winner == 1) MessageBox.Show("Player wins!");
                    else MessageBox.Show("Computer Wins!");
                    stopButton_Click(sender, e);
                }
                else if (winner == -1)
                {
                    MessageBox.Show("Draw!");
                    stopButton_Click(sender, e);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2015 Abdul Sami Farrukh - All Rights Reserved. MCN: CPTQ5-SXNU0-C3VLZ \nDistributed under the Creative Commons Attribution-NonCommercial-ShareAlike 4.0 Public License.", "About Tic Tac Toe");
        }
    }
}

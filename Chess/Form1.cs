using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Chessboard chessboard;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            newGame();

        }
        private void newGame()
        {
            int border = SystemInformation.BorderSize.Height;
            chessboard = new Chessboard();
            this.ClientSize = new Size(chessboard.Size() - border, chessboard.Size() + 30 + 17 - border); // Size of form dependent on size of chessboard, for height + 30 for padding from menu in chessboard.Draw() and + 17 for extra padding to stabilize
            timerPlayer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            chessboard.Draw(e.Graphics);
        }

        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = this.Height.ToString();
            toolStripStatusLabel2.Text = this.Width.ToString();
            toolStripStatusLabel2.Alignment = ToolStripItemAlignment.Right;
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

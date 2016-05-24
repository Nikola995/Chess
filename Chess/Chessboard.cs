using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    [Serializable]
    public class Chessboard
    {
        public Color ForWhite { get; set; }
        public Color ForBlack { get; set; }
        public int SquareSize { get; set; }
        public Chessboard ()//default constructor
        {
            ForWhite = Color.LemonChiffon;
            ForBlack = Color.DarkGoldenrod;
            SquareSize = 60;
        }

        public int Size()
        {
            return SquareSize * 8 + 30; //Size of board + padding from border
        }

        public void Draw(Graphics g)
        {
            Brush whiteBrush = new SolidBrush(ForWhite);
            Brush blackBrush = new SolidBrush(ForBlack);
            bool whiteSquare = true;
            int height = 40;
            for(int i = 0; i < 8; i++)
            {
                int width = 15;
                for (int j = 0; j < 8; j++)
                {
                    if (whiteSquare)
                    {
                        g.FillRectangle(whiteBrush, new Rectangle(width, height, SquareSize, SquareSize));
                    }
                    else
                    {
                        g.FillRectangle(blackBrush, new Rectangle(width, height, SquareSize, SquareSize));
                    }

                    width += SquareSize;
                    whiteSquare = !whiteSquare;
                }
                height += SquareSize;
                whiteSquare = !whiteSquare;
            }
        }
    }
}

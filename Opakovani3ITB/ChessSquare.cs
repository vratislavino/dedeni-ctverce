using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class ChessSquare : Square
    {
        bool[,] bools = new bool[4, 4];

        Brush color1;
        Brush color2;

        public ChessSquare() : base() {
            Paint += OnPaint;
            color1 = new SolidBrush(BackColor);
            color2 = new SolidBrush(Color.DarkMagenta);
        }

        public override void OnMouseClicked(Point position, MouseButtons button) {
            int radek = position.X / (Width / bools.GetLength(0));
            int sloupec = position.Y / (Height / bools.GetLength(1));
            bools[radek, sloupec] = !bools[radek, sloupec];

            Refresh();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            int tileSize = Width / bools.GetLength(0);
            for (int i = 0; i < bools.GetLength(0); i++) {
                for(int j = 0; j < bools.GetLength(1); j++) {
                    e.Graphics.FillRectangle(bools[i, j] ? color1 : color2, i * tileSize, j * tileSize, tileSize, tileSize);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class ResizableSquare : Square
    {
        public override void OnMouseClicked(Point position, MouseButtons button) {
            if(button == MouseButtons.Left) {
                Width = Height = Width - 10;
                if(Width < 10) {
                    Width = Height = 10;
                }
            } else {
                Width = Height = Width + 10;
                if (Width > 200) {
                    Width = Height = 200;
                }
            }
        }
    }
}

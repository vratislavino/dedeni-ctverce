using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class ClickCounterSquare : LabelSquare
    {
        int clickCount = 0;

        public override void OnMouseClicked(Point position, MouseButtons button) {
            if(button == MouseButtons.Left) {
                clickCount--;
            } else {
                clickCount++;
            }

            CustomText = clickCount.ToString();
        }
    }
}

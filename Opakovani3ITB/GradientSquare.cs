using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class GradientSquare : Square
    {
        private bool stateTowards = false;
        private int val = 0;

        public GradientSquare() {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += OnTick;
            timer.Start();
            AddjustColor();
        }

        private void OnTick(object sender, EventArgs e) {
            Console.WriteLine("Called");
            if(stateTowards == true) {
                val = Math.Min(255, val+1);
            } else {
                val = Math.Max(0, val - 1);
            }
            AddjustColor();
        }

        private void AddjustColor() {
            this.BackColor = Color.FromArgb(val, val, val);
        }

        public override void OnMouseClicked(Point position, MouseButtons button) {
            stateTowards = !stateTowards;
        }

    }
}

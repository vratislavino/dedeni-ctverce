using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class DateSquare : LabelSquare
    {
        DateTime current;
        Color currentColor;

        public DateSquare() {
            current = DateTime.Now;
            currentColor = GenerateColor();
            CustomText = current.ToString("dddd");
            Paint += OnPaint;
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(new SolidBrush(currentColor), 10,10, Width-22, Height-22);
        }

        public override void OnMouseClicked(Point position, MouseButtons button) {

            if(button == MouseButtons.Left) {
                current = current.AddDays(-1);
            } else {
                current = current.AddDays(1);
            }

            CustomText = current.ToString("dddd");
            currentColor = GenerateColor();
            Refresh();
        }

        private Color GenerateColor() {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255));
        }
    }
}

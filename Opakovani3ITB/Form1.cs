using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public partial class Form1 : Form
    {
        int squareSize = 100;

        public Form1() {
            InitializeComponent();
            InitMaxValues();
        }

        private void InitMaxValues() {
            int maxX = panel1.Width - squareSize;
            int maxY = panel1.Height - squareSize;

            xInput.Maximum = maxX;
            yInput.Maximum = maxY;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            label1.Visible = label2.Visible = xInput.Visible = yInput.Visible = !checkBox1.Checked;
        }

        private Point GetPosition() {
            if (checkBox1.Checked) {
                Random rand = new Random();
                return new Point(
                    rand.Next(0, (int) xInput.Maximum),
                    rand.Next(0, (int) yInput.Maximum)
                    );

            } else {
                return new Point((int) xInput.Value, (int) yInput.Value);
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e) {
            InitMaxValues();
        }

        private void button1_Click(object sender, EventArgs e) {
            Square sq = new ResizableSquare();
            sq.Location = GetPosition();
            panel1.Controls.Add(sq);
        }
    }
}

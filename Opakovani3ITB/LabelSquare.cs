using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Opakovani3ITB
{
    public abstract class LabelSquare : Square
    {
        private Label label;

        public LabelSquare() : base() {
            PrepareLabel();
        }

        private void PrepareLabel() {
            label = new Label();
            label.AutoSize = false;
            label.Width = Width;
            label.Height = Height / 3;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "---";
            label.Location = new Point(0, label.Height);
            label.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Regular);
            label.MouseClick += OnLabelMouseClick;
            this.Controls.Add(label);
        }

        private void OnLabelMouseClick(object sender, MouseEventArgs e) {
            OnMouseClicked(new Point(e.X, label.Location.Y + e.Y), e.Button);
        }

        public string CustomText {
            get { return label.Text; }
            set { label.Text = value; }
        }
        
    }
}

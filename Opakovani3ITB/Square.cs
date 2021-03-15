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
    public abstract partial class Square : UserControl
    {
        public Square() {
            InitializeComponent();
            BackColor = ColorProvider.GetColorByType(this.GetType());
        }

        private void Square_MouseClick(object sender, MouseEventArgs e) {
            OnMouseClicked(e.Location, e.Button);
        }

        public abstract void OnMouseClicked(Point position, MouseButtons button);
    }
}

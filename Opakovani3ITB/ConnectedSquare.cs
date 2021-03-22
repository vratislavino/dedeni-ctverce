using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class ConnectedSquare : Square
    {
        public event Action ConnectedChanged;

        private bool isConnected = false;
        public bool IsConnected { get { return isConnected; } }

        public override void OnMouseClicked(Point position, MouseButtons button) {
            isConnected = !isConnected;

            BackColor = isConnected ? Color.DeepSkyBlue : Color.SkyBlue;

            ConnectedChanged?.Invoke();
        }
    }
}

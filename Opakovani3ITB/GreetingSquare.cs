using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani3ITB
{
    public class GreetingSquare : LabelSquare
    {
        private string[] texts = new string[] { "Ahoj", "Čau", "Nazdar", "Zdravstvujte", "Tě péro!", "Dobré dopoledne", "Slyšíme se?" };
        private int currentText = 0;

        public GreetingSquare() : base() {
            RefreshText();
        }

        private void RefreshText() {
            CustomText = texts[currentText];
        }

        public override void OnMouseClicked(Point position, MouseButtons button) {
            currentText++;
            currentText %= texts.Length;
            RefreshText();
        }
    }
}

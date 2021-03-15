using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani3ITB
{
    public class ColorProvider
    {
        private static Dictionary<Type, Color> _colors = new Dictionary<Type, Color>() {
            { typeof(ResizableSquare), Color.Gold },
            { typeof(ClickCounterSquare), Color.DarkRed }
        };

        public static Color GetColorByType(Type t) {
            if(_colors.ContainsKey(t)) {
                return _colors[t];
            }
            Console.WriteLine($"Pro typ {t.Name} není definovaná barva!");
            return Color.Black;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrintRecord
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() {


            "#d6eaf8",
            "#aed6f1",
            "#85c1e9",
            "#5dade2",
            "#3498db",
            "#2e86c1"



        };

     /*   internal static Color ChangeColorBrightness()
        {
            throw new NotImplementedException();
        }*/

        public static Color ChangeColorBrightness(Color color , double connectionFactor) {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(connectionFactor < 0)
            {
                connectionFactor = 1 + connectionFactor;
                red *= connectionFactor;
                green *= connectionFactor;
                blue *= connectionFactor;
            }
            else
            {
                red = (255 - red) * connectionFactor + red;
                green = (255 - green) * connectionFactor + green;
                blue = (255 - blue) * connectionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

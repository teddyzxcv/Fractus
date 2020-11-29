using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fractus
{
    public class Fractus
    {
        public static List<Color> ColorList = new List<Color>();
        public static List<Color> GenerateColorList(Color startColor, Color endColor, int LevelRecursion)
        {
            ColorList = new List<Color>();
            if (LevelRecursion == 0)
            {
                ColorList.Add(endColor);
                return ColorList;
            }
            for (int i = 0; i <= LevelRecursion; i++)
            {
                var rAdverage = startColor.R + (int)((endColor.R - startColor.R) * i / (LevelRecursion + 1));
                var gAdverage = startColor.G + (int)((endColor.G - startColor.G) * i / (LevelRecursion + 1));
                var bAdverage = startColor.B + (int)((endColor.B - startColor.B) * i / (LevelRecursion + 1));

                ColorList.Add(Color.FromArgb(255, rAdverage, gAdverage, bAdverage));
            }
            return ColorList;
        }
        public int Size { get; set; }
        public int LevelRecursion { get; set; }
        public Bitmap bm { get; set; }
        public Point StartPoint { get; set; }
    }
}

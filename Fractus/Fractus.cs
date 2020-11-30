using System.Collections.Generic;
using System.Drawing;
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
            for (int i = 0; i < LevelRecursion; i++)
            {
                var rAdverage = startColor.R + (int)((endColor.R - startColor.R) * i / (LevelRecursion));
                var gAdverage = startColor.G + (int)((endColor.G - startColor.G) * i / (LevelRecursion));
                var bAdverage = startColor.B + (int)((endColor.B - startColor.B) * i / (LevelRecursion));

                ColorList.Add(Color.FromArgb(255, rAdverage, gAdverage, bAdverage));
            }
            return ColorList;
        }
        public int Size { get; set; }
        public int LevelRecursion { get; set; }
        public Bitmap bm { get; set; }
        public Point StartPoint { get; set; }

        public static int PenSize = 1;
    }
}

using System.Collections.Generic;
using System.Drawing;
namespace Fractus
{
    public class Fractus
    {
        /// <summary>
        /// Save color gradient for all recursions.
        /// </summary>
        /// <typeparam name="Color"></typeparam>
        /// <returns></returns>
        public static List<Color> ColorList = new List<Color>();
        /// <summary>
        /// Generate the color gradient use start color and end color and step of recursion.
        /// </summary>
        /// <param name="startColor"></param>
        /// <param name="endColor"></param>
        /// <param name="LevelRecursion"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Size of all fractal.
        /// </summary>
        /// <value></value>
        public int Size { get; set; }
        /// <summary>
        /// Step of recursion.
        /// </summary>
        /// <value></value>
        public int LevelRecursion { get; set; }
        /// <summary>
        /// Bitmap for save image.
        /// </summary>
        /// <value></value>
        public Bitmap bm { get; set; }
        /// <summary>
        /// Start coordinate.
        /// </summary>
        /// <value></value>
        public Point StartPoint { get; set; }
        /// <summary>
        /// Pen size for all fractal.
        /// </summary>
        public static int PenSize = 1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;
namespace Fractus
{
    class CantorSetR : Fractus
    {
        public int Distance { get; set; }
        /// <summary>
        /// Paint the fractal.
        /// </summary>
        public void Paint()
        {
            CantorSetRecursion(StartPoint, Distance, Size, bm, LevelRecursion);
        }
        /// <summary>
        /// Recursion function for cantor set.
        /// </summary>
        /// <param name="CurrentPoint"></param>
        /// <param name="Distance"></param>
        /// <param name="size"></param>
        /// <param name="bm"></param>
        /// <param name="LevelRecursion"></param>
        public static void CantorSetRecursion(Point CurrentPoint, int Distance, double size, Bitmap bm, int LevelRecursion)
        {
            if (LevelRecursion > 0)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Brush br = new SolidBrush(ColorList[LevelRecursion - 1]))
                    {
                        gr.DrawLine(new Pen(br, PenSize), Point.Add(CurrentPoint, new Size((int)(size / 2), 0)), Point.Subtract(CurrentPoint, new Size((int)(size / 2), 0)));
                    }
                }
                CantorSetRecursion(Point.Add(CurrentPoint, new Size((int)(size / 3), Distance)), Distance, size / 3, bm, LevelRecursion - 1);
                CantorSetRecursion(Point.Add(CurrentPoint, new Size(-(int)(size / 3), Distance)), Distance, size / 3, bm, LevelRecursion - 1);
            }
        }
    }
}

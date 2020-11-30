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
        public void Paint()
        {
            CantorSetRecursion(StartPoint, Distance, Size, bm, LevelRecursion);
        }
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

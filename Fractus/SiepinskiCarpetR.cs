using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace Fractus
{
    class SiepinskiCarpetR : Fractus
    {
        public void Paint()
        {
            using (Graphics gr = Graphics.FromImage(bm))
            {
                using (Brush br = new SolidBrush(ColorList[0]))
                {
                    Rectangle rec = new Rectangle(StartPoint, new Size(Size, Size));
                    gr.FillRectangle(br, rec);
                }
            }
            SierpinskiCarpetRecursion(StartPoint, LevelRecursion - 1, Size, bm);
        }
        public void SierpinskiCarpetRecursion(Point CurrentPoint, int LevelRecursion, int size, Bitmap bm)
        {
            if (LevelRecursion == -1)
            {
                return;
            }
            if (LevelRecursion >= 0)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {

                    using (SolidBrush br = new SolidBrush(ColorList[LevelRecursion + 1]))
                    {
                        Rectangle rec = new Rectangle(Point.Add(CurrentPoint, new Size(size / 3, size / 3)), new Size(size / 3, size / 3));
                        gr.FillRectangle(br, rec);
                    }
                }
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Add(CurrentPoint, new Size(0, size / 3));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Add(CurrentPoint, new Size(0, size / 3));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Add(CurrentPoint, new Size(size / 3, 0));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Add(CurrentPoint, new Size(size / 3, 0));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Subtract(CurrentPoint, new Size(0, size / 3));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Subtract(CurrentPoint, new Size(0, size / 3));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
                CurrentPoint = Point.Subtract(CurrentPoint, new Size(size / 3, 0));
                SierpinskiCarpetRecursion(CurrentPoint, LevelRecursion - 1, size / 3, bm);
            }
        }
    }
}

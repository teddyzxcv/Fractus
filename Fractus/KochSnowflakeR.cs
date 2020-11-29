using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;


namespace Fractus
{
    class KochSnowflakeR : Fractus
    {



        public void Paint()
        {
            KochSnowflakwRecursion(ColorList[0], LevelRecursion, StartPoint, out PointF apoint, Size, 180, LevelRecursion, bm);
        }
        public void KochSnowflakwRecursion(Color startColor, int LevelRecursion, PointF startPoint, out PointF afterPoint, double Distance, int Angle, int RecursionColor, Bitmap bm)
        {
            afterPoint = new PointF();


            if (LevelRecursion == 0)
            {
                if (ColorList.Count != 0 && RecursionColor > 0)
                {
                    startColor = ColorList[RecursionColor - 1];
                }
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Pen thick_pen = new Pen(startColor, 1))
                    {
                        afterPoint.Y = (float)(startPoint.Y + Math.Round((Math.Sin(Angle * (Math.PI / 180)) * Distance)));
                        afterPoint.X = (float)(startPoint.X + Math.Round((Math.Cos(Angle * (Math.PI / 180)) * Distance)));
                        gr.DrawLine(thick_pen, startPoint, afterPoint);
                    }
                }
            }
            else
            {
                double CurrentDistance = (afterPoint.Y - startPoint.Y) / 3;
                int CurrentAngle = Angle;
                PointF aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion - 1], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, RecursionColor, bm);
                CurrentAngle += 60;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion - 1], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, RecursionColor - 1, bm);
                CurrentAngle -= 120;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion - 1], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, RecursionColor - 1, bm);
                CurrentAngle += 60;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion - 1], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, RecursionColor, bm);
                afterPoint = aPoint;
            }
        }
    }
}

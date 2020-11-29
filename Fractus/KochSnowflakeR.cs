using System;
using System.Drawing;


namespace Fractus
{
    class KochSnowflakeR : Fractus
    {
        public void Paint()
        {
            KochSnowflakwRecursion(ColorList[0], LevelRecursion, StartPoint, out Point apoint, Size, 180, bm);
        }
        public void KochSnowflakwRecursion(Color startColor, int LevelRecursion, Point startPoint, out Point afterPoint, double Distance, int Angle, Bitmap bm)
        {
            afterPoint = new Point();

            if (LevelRecursion == 0)
            {
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Pen thick_pen = new Pen(startColor, 1))
                    {
                        afterPoint.Y = startPoint.Y + (int)Math.Round((Math.Sin(Angle * (Math.PI / 180)) * Distance));
                        afterPoint.X = startPoint.X + (int)Math.Round((Math.Cos(Angle * (Math.PI / 180)) * Distance));
                        gr.DrawLine(thick_pen, startPoint, afterPoint);
                    }
                }
            }
            else
            {
                int CurrentDistance = (afterPoint.Y - startPoint.Y) / 3;
                int CurrentAngle = Angle;
                Point aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, bm);
                CurrentAngle += 60;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, bm);
                CurrentAngle -= 120;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, bm);
                CurrentAngle += 60;
                startPoint = aPoint;
                KochSnowflakwRecursion(ColorList[LevelRecursion], LevelRecursion - 1, startPoint, out aPoint, Distance / 3, CurrentAngle, bm);
                afterPoint = aPoint;
            }
        }
    }
}

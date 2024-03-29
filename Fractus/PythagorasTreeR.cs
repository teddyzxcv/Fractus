﻿using System;
using System.Drawing;

namespace Fractus
{
    public class PythagorasTreeR : Fractus
    {

        public int FractionBetweenRecursion { get; set; }
        public int PythagorasAngle1
        { get; set; }
        public int PythagorasAngle2 { get; set; }
        /// <summary>
        /// Standard paint method for every fractal.
        /// </summary>
        public void Paint()
        {
            PythagorasTreeRecursion(StartPoint, LevelRecursion, bm, 0, Size);
        }


        /// <summary>
        /// Draw the recursion use these given parameter.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="LevelRecursion"></param>
        /// <param name="bm"></param>
        /// <param name="Angle"></param>
        /// <param name="Distance"></param>
        public void PythagorasTreeRecursion(Point startPoint, int LevelRecursion, Bitmap bm, int Angle, double Distance)
        {
            if (LevelRecursion > 0)
            {


                Point afterPoint = new Point();
                afterPoint.X = startPoint.X + (int)(Math.Sin(Angle * (Math.PI / 180)) * Distance);
                afterPoint.Y = startPoint.Y + (int)(Math.Cos(Angle * (Math.PI / 180)) * Distance);

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Pen thick_pen = new Pen(ColorList[LevelRecursion - 1], PenSize))
                    {
                        gr.DrawLine(thick_pen, startPoint, afterPoint);
                    }
                }
                PythagorasTreeRecursion(afterPoint, LevelRecursion - 1, bm, Angle + PythagorasAngle1, Distance / ((double)(FractionBetweenRecursion) / 100));
                PythagorasTreeRecursion(afterPoint, LevelRecursion - 1, bm, Angle - PythagorasAngle2, Distance / ((double)(FractionBetweenRecursion) / 100));
            }
            else
                return;
        }


    }
}

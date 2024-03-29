﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;


namespace Fractus
{
    class SiepinskiTriangleR : Fractus
    {
        /// <summary>
        /// Standard paint method for every fractal.
        /// Draw the initial position of fractal.
        /// </summary>
        public void Paint()
        {

            using (Graphics gr = Graphics.FromImage(bm))
            {
                using (Brush br = new SolidBrush(ColorList.Last()))
                {

                    Point[] points = new Point[3];
                    points[0] = Point.Subtract(StartPoint, new Size(0, (int)(Size / (2 * Math.Sin(Math.PI / 3)))));
                    points[1] = Point.Subtract(StartPoint, new Size((int)(Size / 2), -(int)(Math.Sin(Math.PI / 6) * (Size / (2 * Math.Sin(Math.PI / 3))))));
                    points[2] = Point.Add(StartPoint, new Size((int)(Size / 2), (int)(Math.Sin(Math.PI / 6) * (Size / (2 * Math.Sin(Math.PI / 3))))));


                    gr.DrawPolygon(new Pen(br, PenSize), points);
                }
            }
            SierpinskiTriangle(StartPoint, LevelRecursion, Size / 2, bm);

        }
        /// <summary>
        /// Draw recursion use given parameter.
        /// </summary>
        /// <param name="CurrrentPoint"></param>
        /// <param name="LevelRecursion"></param>
        /// <param name="size"></param>
        /// <param name="bm"></param>
        public void SierpinskiTriangle(Point CurrrentPoint, int LevelRecursion, double size, Bitmap bm)
        {
            if (LevelRecursion == -1)
            {
                return;
            }
            if (LevelRecursion > 0)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Brush br = new SolidBrush(ColorList[LevelRecursion]))
                    {
                        Point[] points = new Point[3];
                        points[0] = Point.Add(CurrrentPoint, new Size(0, (int)(size / (2 * Math.Sin(Math.PI / 3)))));
                        points[1] = Point.Add(CurrrentPoint, new Size((int)(size / 2), -(int)(Math.Sin(Math.PI / 6) * (size / (2 * Math.Sin(Math.PI / 3))))));
                        points[2] = Point.Subtract(CurrrentPoint, new Size((int)(size / 2), (int)(Math.Sin(Math.PI / 6) * (size / (2 * Math.Sin(Math.PI / 3))))));
                        gr.DrawPolygon(new Pen(br, PenSize), points);
                    }
                }
                double DisToP = (2 * size * Math.Sin(Math.PI / 3)) / 3;
                SierpinskiTriangle(Point.Subtract(CurrrentPoint, new Size(0, (int)DisToP)), LevelRecursion - 1, size / 2, bm);
                SierpinskiTriangle(Point.Add(CurrrentPoint, new Size((int)(Math.Sin(Math.PI / 3) * DisToP), (int)(Math.Cos(Math.PI / 3) * DisToP))), LevelRecursion - 1, size / 2, bm);
                SierpinskiTriangle(Point.Subtract(CurrrentPoint, new Size((int)(Math.Sin(Math.PI / 3) * DisToP), -(int)(Math.Cos(Math.PI / 3) * DisToP))), LevelRecursion - 1, size / 2, bm);


            }
        }
    }
}

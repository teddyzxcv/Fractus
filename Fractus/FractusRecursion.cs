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
    public class FractusRecursion
    {
        public static List<Color> ColorList = new List<Color>();

        public static void GenerateColorList(Color startColor, Color endColor, int LevelRecursion)
        {
            ColorList = new List<Color>();
            for (int i = 0; i <= LevelRecursion; i++)
            {
                var rAdverage = startColor.R + (int)((endColor.R - startColor.R) * i / (LevelRecursion + 1));
                var gAdverage = startColor.G + (int)((endColor.G - startColor.G) * i / (LevelRecursion + 1));
                var bAdverage = startColor.B + (int)((endColor.B - startColor.B) * i / (LevelRecursion + 1));

                ColorList.Add(Color.FromArgb(255, rAdverage, gAdverage, bAdverage));
            }
        }
        public static int PythagorasAngle1
        {
            get; set;
        }
        public static int PythagorasAngle2 { get; set; }
        public static int FractionBetweenRecursion { get; set; }




        public static void PythagorasTreeRecursion(Point startPoint, int LevelRecursion, Bitmap bm, int Angle, double Distance)
        {
            if (LevelRecursion > 0)
            {


                Point afterPoint = new Point();
                afterPoint.X = startPoint.X + (int)(Math.Sin(Angle * (Math.PI / 180)) * Distance);
                afterPoint.Y = startPoint.Y + (int)(Math.Cos(Angle * (Math.PI / 180)) * Distance);

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Pen thick_pen = new Pen(ColorList[LevelRecursion - 1], 1))
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


        public static void KochSnowflakwRecursion(Color startColor, int LevelRecursion, Point startPoint, out Point afterPoint, double Distance, int Angle, Bitmap bm)
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

        public static void SierpinskiCarpetRecursion(Point CurrentPoint, int LevelRecursion, int size, Bitmap bm)
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
        public static void SierpinskiTriangle(Point CurrrentPoint, int LevelRecursion, double size, Bitmap bm)
        {
            if (LevelRecursion == -1)
            {
                return;
            }
            if (LevelRecursion >= 0)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Brush br = new SolidBrush(ColorList[LevelRecursion + 1]))
                    {
                        Point[] points = new Point[3];
                        points[0] = Point.Add(CurrrentPoint, new Size(0, (int)(size / (2 * Math.Sin(Math.PI / 3)))));
                        points[1] = Point.Add(CurrrentPoint, new Size((int)(size / 2), -(int)(Math.Sin(Math.PI / 6) * (size / (2 * Math.Sin(Math.PI / 3))))));
                        points[2] = Point.Subtract(CurrrentPoint, new Size((int)(size / 2), (int)(Math.Sin(Math.PI / 6) * (size / (2 * Math.Sin(Math.PI / 3))))));
                        gr.DrawPolygon(new Pen(br), points);
                    }
                }
                double DisToP = (2 * size * Math.Sin(Math.PI / 3)) / 3;
                SierpinskiTriangle(Point.Subtract(CurrrentPoint, new Size(0, (int)DisToP)), LevelRecursion - 1, size / 2, bm);
                SierpinskiTriangle(Point.Add(CurrrentPoint, new Size((int)(Math.Sin(Math.PI / 3) * DisToP), (int)(Math.Cos(Math.PI / 3) * DisToP))), LevelRecursion - 1, size / 2, bm);
                SierpinskiTriangle(Point.Subtract(CurrrentPoint, new Size((int)(Math.Sin(Math.PI / 3) * DisToP), -(int)(Math.Cos(Math.PI / 3) * DisToP))), LevelRecursion - 1, size / 2, bm);


            }
        }
        public static void CantorSetRecursion(int Distance, double size, Bitmap bm, int LevelRecursion)
        {
            if (LevelRecursion > 0)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    using (Brush br = new SolidBrush(ColorList[LevelRecursion + 1]))
                    {

                    }
                }


            }
        }
    }

}

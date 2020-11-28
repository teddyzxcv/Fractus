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
            for (int i = 0; i < LevelRecursion; i++)
            {
                var rAdverage = startColor.R + (int)((endColor.R - startColor.R) * i / LevelRecursion);
                var gAdverage = startColor.G + (int)((endColor.G - startColor.G) * i / LevelRecursion);
                var bAdverage = startColor.B + (int)((endColor.B - startColor.B) * i / LevelRecursion);
                ColorList.Add(Color.FromArgb(rAdverage, gAdverage, bAdverage));
            }
        }

        public static void PythagorasTreeRecursion(Point startPoint, int LevelRecursion, Bitmap bm, int Angle, int Distance, int ConstAngle)
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
                PythagorasTreeRecursion(afterPoint, LevelRecursion - 1, bm, Angle + ConstAngle, Distance / 2, ConstAngle);
                PythagorasTreeRecursion(afterPoint, LevelRecursion - 1, bm, Angle - ConstAngle, Distance / 2, ConstAngle);
            }
            else
                return;
        }
    }

}

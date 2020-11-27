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
        public static void PythagorasTreeRecursion(Point startPoint, int LevelRecursion, Bitmap bm)
        {


            using (Graphics gr = Graphics.FromImage(bm))
            {
                using (Pen thick_pen = new Pen(Color.Blue, 5))
                {
                    gr.DrawLine(thick_pen, startPoint, new Point(100, 100));
                }
            }


        }
    }

}

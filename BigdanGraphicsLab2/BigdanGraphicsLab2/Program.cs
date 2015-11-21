using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigdanGraphicsLab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            float[] xn = new float[100];
            float[] xc = new float[100];
            float[] yn = new float[100];
            float[] yc = new float[100];
            float[] zn = new float[100];
            float[] zc = new float[100];
            int[] cona = new int[100];
            int[] conb = new int[100];
            int con;
            float z0;
            int i;
            float dx, dy;
            int currx, curry;
            int xmiracle, ymiracle, zmiracle;
            int chdraw;
            int n;
        }
    }

    class R4
    {
        public R4(double angle1, double angle2, double angle3, double sx, double sy, double sz, double xt, double yt, double zt, double x1, double y1, double z1)
        {
            double A, B, C, D, E, F, G, H, I;
            double tx, ty, tz;
            double k;

            angle1 = (Math.PI / 180) * angle1;
            angle2 = (Math.PI / 180) * angle2;
            angle3 = (Math.PI / 180) * angle3;

            A = Math.Cos(angle2) * Math.Cos(angle1);
            B = Math.Sin(angle3) * Math.Sin(angle2) * Math.Cos(angle1) + Math.Cos(angle3) * Math.Sin(angle1);
            C = Math.Cos(angle3) * Math.Cos(angle1) * Math.Sin(angle2) - Math.Sin(angle3) * Math.Sin(angle1);
            D = -Math.Sin(angle1) * Math.Cos(angle2);
        }
    }
}

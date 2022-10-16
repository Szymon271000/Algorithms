using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cubic
    {
        public int A;
        public int B;
        public int C;
        public int D;

        public Cubic(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public void Calculate(int a, int b, int c, int d)
        {
            if (a > 0)
            {
                double w = (b / (3 * a)) * -1;
                double p = (3 * a * (Math.Pow(w, 2)) + (2 * b * w) + c) / a;
                double q = (a * (Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
                double delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);

                if (delta > 0)
                {
                    double u3 = (-1 * (q / 2)) + Math.Sqrt(delta);
                    double u = Math.Cbrt(u3);

                    double v3 = (-1 * (q / 2)) - Math.Sqrt(delta);
                    double v = Math.Cbrt(v3);

                    double x1 = u + v + w;

                    double Rex2 = ((u + v) / (-2)) + w;
                    double Rex3 = ((u + v) / (2)) + w;

                    double Jm2 = ((Math.Sqrt(3) / 2) * (u - v));
                    double Jm3 = (-1 * ((Math.Sqrt(3) / 2)) * (u - v));

                    Console.WriteLine(x1);
                    Console.WriteLine(Rex2);
                    Console.WriteLine(Rex3);
                    Console.WriteLine(Jm2);
                    Console.WriteLine(Jm3);
                }
                else if (delta == 0)
                {
                    double x1 = w - (2 * (Math.Cbrt(q / 2)));
                    double x2 = w + (2 * (Math.Cbrt(q / 2)));
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
                else
                {
                    double Phi = Math.Acos((3 * q) / ((2 * p) * Math.Sqrt((-1 * p) / 3)));
                    double x1 = w + (2 * Math.Sqrt((p / 3) * -1) * Math.Cos(Phi / 3));
                    double x2 = w + (2 * Math.Sqrt((p / 3) * -1) * Math.Cos(Phi / 3 + (2 * Math.PI) / 3));
                    double x3 = w + (2 * Math.Sqrt((p / 3) * -1) * Math.Cos(Phi / 3) + (4 * Math.PI) / 3);
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                    Console.WriteLine(x3);

                }
            }
        }
    }
}

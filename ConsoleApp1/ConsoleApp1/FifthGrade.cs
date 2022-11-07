using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FifthGrade
    {
        public int A;
        public int B;
        public int C;
        public int D;
        public int E;
        public int F;

        public FifthGrade(int a, int b, int c, int d, int e, int f)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
            F = f;
        }

        private double Func(double x)
        {
            return x * x * x * x *x * A + x * x * x * x * B + x * x * x * C + x * x * D + x * E + F;
        }

        public double Calculate(double start, double end, double eps)
        {
            double fa = Func(start);
            double fb = Func(end);
            if(fa * fb > 0)
            {
                throw new Exception("Error");
            }

            double x0;
            while(true)
            {
                x0 = (start + end) / 2;
                if(Math.Abs(start - x0) < eps)
                {
                    break;
                }

                double fx = Func(x0);
                if(Math.Abs(fx) < eps)
                {
                    break;
                }

                if(fx * fa < 0)
                {
                    end = x0;
                }
                else
                {
                    start = x0;
                    fa = fx;
                }
            }
            return x0;
        }
    }
}

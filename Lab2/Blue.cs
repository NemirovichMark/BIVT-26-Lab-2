using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {

            double answer = 0;
            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(x * i) / p;
                p *= x;
            }

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double p = 5;
            double q = -1; 
            double w = 1;
            for (int i = 1; i <= n; i++)
            {
                w *= i;
                answer += q*(p/w);
                p *= 5;
                q *= -1;
            }



            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long a = 0;
            long b = 1;
            long c = 0;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                c = a+b;
                a = b;
                b = c;
                
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int s = 0;

            for (int i = 0; s + (a + h * i) <= L; i++)
            {
                s += a + h * i;
                answer += 1;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double  ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                
                i++;
            }
            while (elem > 0.0001);


            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            while  (S < L)
                {
                answer+=h;
                S = S * 2;
            }

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            double d = 0;
            int i = 0;
            int w = 5;
            double ansA=0;
            int ansB=0;
            while (i < 7 || ansB == 0 || S <= 42)
            {
                a += S;
                b++;
                i++;

                if (i == 7) ansA = a;
                if (a >= 100 && ansB == 0) ansB = b;
                if (S <= 42) c++;

                d = S * (1 + I / 100);
                S = d;

            }

            return (ansA, ansB, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + E; x += h)
            {
                double s = 0;
                double p = 1;
                double f = 1;
                double elem = 1;
                int i = 0;

                while (Math.Abs(elem) >= E)
                {
                    s += elem;

                    i++;
                    p *= x * x;
                    f *= i;

                    elem = (2 * i + 1) * p / f;
                }

                s += elem;

                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }

            return (SS, SY);
        }
    }
}

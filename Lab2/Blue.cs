using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double add = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / add;
                add *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double add1 = 1;
            double add2 = 1;
            for (int i = 1; i <= n; i++)
            {
                add1 *= -5;
                add2 *= i;
                answer += add1 / add2;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int add1 = 0;
            int add2 = 1;
            int per = 0;
            for ( int i = 0; i < n - 1; i++)
            {
                answer += add2;
                per = add2;
                add2 += add1;
                add1 = per;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int n = 1;
            while(true)
            {
                s += a + (n - 1) * h;
                n += 1;
                if (s > L)
                {
                    break;
                }
                answer += 1;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
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
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int c = 0;
            for (int i = 1; S < L; i++)
            {
                S *= 2;
                c = i;
            }
            answer = h * c;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double s = 0;
            int i = 0;
            bool t1 = true;
            bool t2 = true;
            bool t3 = true;
            if (t2 && s >= 100)
            {
                b = i;
                t2 = false;
            }
            if (t3 && S > 42)
            {
                c = i;
                t3 = false;
            }
            do
            {
                i += 1;
                s += S;
                
                if (t1 && i == 7)
                {
                    a = s;
                    t1 = false;
                }
                if (t2 && s >= 100)
                {
                    b = i;
                    t2 = false;
                }
                if (t3 && S > 42)
                {
                    c = i - 1;
                    t3 = false;
                }
                S *= 1 + (I / 100.0);
            } while (t2 || t3 || t1);
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + 0.0000001)
            {
                double s = 0;
                double t = 1;
                double f = 1;
                double st = 1;
                int i = 0;
                while (Math.Abs(t) >= E)
                {
                    t = (2 * i + 1) * st / f;
                    s += t;
                    i++;
                    f *= i;
                    st = st * x * x;
                }
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;
                x += h;

            }

            // end

            return (SS, SY);
        }
    }
}

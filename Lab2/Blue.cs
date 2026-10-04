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

            // code here
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                double r = Math.Sin(i * x) / a;
                answer += r;
                a *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double ch = 1;
            double f = 1;
            double a = -1;
            for (int i = 1; i <= n; i++)
            {
                ch *= 5;
                f *= i;
                double r = a * (ch / f);
                answer += r;
                a = -a;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i ++)
            {
                answer += a;
                int c = a + b;
                a = b;
                b = c;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double sum = 0;
            int r = a;
            while (sum + r <= L)
            {
                sum += r;
                answer++;
                r += h;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
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
            int n = S;
            while (n < L)
                {
                n *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double sumS = S;
            for (int day = 1; day <= 7; day++)
            {
                a += sumS;
                sumS += sumS * (I / 100);
            }
            sumS = S;
            double put = 0;
            while (put <= 100)
            {
                b++;
                put += sumS;
                sumS += sumS * (I / 100);
            }
            sumS = S;
            while (sumS <= 42)
            {
                c++;
                sumS += sumS * (I / 100);
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double E = 0.0001;
            double b1 = Math.Round(b, 9);

            for (int n = 0; ; n++)
            {
                double x = a + n * h;
                if (Math.Round(x, 9) > b1)
                {
                    break;
                }
                double s = 0;
                double f = 1;
                double pow = 1;
                double s1;
                int i = 0;
                do
                {
                    s1 = (2 * i + 1) * pow / f;
                    s += s1;
                    i++;
                    f *= i;
                    pow *= x * x;
                }
                while (Math.Abs(s1) >= E);
                SS += s;
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
            return (SS, SY);
        }
    }
}

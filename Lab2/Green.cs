using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            double k = 0;
            for (int i = 2; i <= n; i += 2)
                k += (double)i / (i + 1);
            answer = k;

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double s = 1.0;
            double su = 1.0;

            for (int i = 1; i <= n; i++)
            {
                s = s / x;
                su = su + s;

            }

            answer = su;
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long s = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += s;
                s *= i + 1;
            }
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double ep = 0.0001;
            double s = x;
            int i = 1;

            while (true)
            {
                double c = Math.Sin(i * s);

                if (Math.Abs(c) < ep)
                {
                    break;
                }
                answer += c;
                i++;
                s = s * x;
            }

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            double eps = 0.0001;
            double p = 1.0;
            double c = 1.0 / x;
            int n = 1;

            while (true)
            {
                if (Math.Abs(c - p) < eps)
                {
                    return n;
                }
                n++;
                p = c;
                c /= x;
            }

            answer = n;
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            while (L > Da)
            {
                L = L / 2.0;
                answer++;
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            for (int k = 0; a + k * h <= b + 0.000001; k++)
            {
                double x = a + k * h;
                double s = 0;
                double p = x;
                int i = 0;
                while (true)
                {
                    s += p;
                    if (Math.Abs(p) < eps)
                    {
                        break;
                    }
                    i++;
                    p = p * (-1) * x * x * (2 * i - 1) / (2 * i + 1);
                }
                SS += s;
                SY += Math.Atan(x);
            }

            return (SS, SY);
        }
    }
}

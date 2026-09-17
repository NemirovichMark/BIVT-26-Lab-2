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
            double a = 1.0;

            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / a;
                a *= x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            long factorial = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                factorial = 1;
                for (int j = 1; j <= i; j++) factorial *= j;
                answer += Math.Pow(-1, i) * Math.Pow(5, i) / factorial;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int first = 0;
            int second = 1;
            int a = 0;

                for (int i = 0; i < n; i++)
                {
                    answer += first;
                    a = first + second;
                    first = second;
                    second = a;

                }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int n = 1; n < 10_000; n++)
            {
                int b = a + (n - 1) * h;
                if (s + b <= L)
                {
                    s += b;
                    answer = n;
                }
                else break;
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
            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
                if (elem > 0.0001)
                {
                    continue;
                }
                else break;
            }
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int schet = 0;
            for (int i = 0; i < 10_000; i++)
            {
                while (S <= L)
                {
                    S *= 2;
                    schet += 1;
                }
                answer = schet  * h;
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
            a = S;
            double day = S;
            double a0 = S;

            for (int i = 1; i < 10_000; i++)
            {
                if (i == 7) a = day;
                if (day >= 100 && b == 0) b = i;
                if (a0 > 42 && c == 0) c = i;
                a0 += a0 / 100 * I;
                day += a0;
            }
            // end

            return (a, b, c - 1);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double s = 0;
            // code here
            for (double x = a; x <= b + 0.000000001; x += h)
            {
                double fact = 1;
                double pow = 1;
                s = 0;
                for (int i = 0; i < 10_000; i++)
                {
                    if (i > 0)
                    {
                        fact *= i;
                        pow *= x * x;
                    }
                    double r = (2 * i + 1) * pow / fact;
                    s += r;
                    if (Math.Abs(r) < E) break;
                }
                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end
            return (SS, SY);
        }
    }
}
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
            double power = 1.0;
            for (int i = 1; i <= n; ++i)
            {
                answer += Math.Sin(i * x) / power;
                power *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double power = 5.0;
            for (double i = 1.0, fact = 1.0; i <= n; ++i)
            {
                fact *= i;
                if (i % 2 != 0)
                    answer -= power / fact;
                else
                    answer += power / fact;
                power *= 5;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0, b = 1, next = 0;

            for (int i = 0; i < n; ++i)
            {
                next = a + b;
                answer += a;
                a = b;
                b = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            for (int s = 0, i = 0; s <= L; ++i)
            {
                s += a + i * h;
                if (s <= L)
                    answer += 1;
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
            }
            while (elem > 0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            for (; S < L; answer += h)
                S *= 2;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            // a
            double i = 1 + (I / 100.0), res = 1;
            for (int n = 0; n < 7; ++n) {
                a += S * res;
                res *= i;
            }
            // b
            double i2 = 1 + (I / 100.0), res2 = 1;
            for (double j = 0; j < 100;b++) {
                j += S * res2;
                res2 *= i2;
            }
            // c
            double i3 = 1 + (I / 100.0), res3 = 1;
            for (double j = 0; j <= 42;) {
                j = S * res3;
                res3 *= i3;
                if (j <= 42)
                    ++c;
            }


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double eps = 0.0001;
            for (double x = a; x <= b + 0.00001; x += h) {
                double ch = 99999999, curent_sum = 0;
                for (int i = 0; Math.Abs(ch) >= eps; i++)
                {
                    double res1 = 1, i1 = x, end1 = 2 * i;
                    for (double j = 0; j < end1; ++j)
                        res1 *= i1;
                    int end2 = i;
                    long res2 = 1;
                    for (int j = 1; j <= end2; ++j)
                        res2 *= j;
                    ch = ((2 * i + 1) * res1) / res2;
                    curent_sum += ch;
                }
                SS += curent_sum;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);

            }
            // end

            return (SS, SY);
        }
    }
}

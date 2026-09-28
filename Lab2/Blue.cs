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

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}

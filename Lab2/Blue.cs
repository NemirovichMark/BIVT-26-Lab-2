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
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / pow;
                pow *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double sg = -1;
            double ch = 5;
            double zn = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += sg * ch / zn;
                sg *= -1;
                ch *= 5;
                zn *= i + 1;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a1 = 0, a2 = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a1;
                long ne = a1 + a2;
                a1 = a2;
                a2 = ne;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int p = a;
            while (s + p <= L)
            {
                s += p;
                p += h;
                answer++;
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
            while (elem > E);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                S = S * 2;
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
            double S1, S2, S3, R1, R2, R3;
            S1 = S;
            R1 = S;
            S2 = S;
            R2 = S;
            S3 = S;
            R3 = S;
            for (int i = 1; i < 7; i++)
            {
                S1 = S1 * (1 + (I / 100));
                R1 += S1;

            }
            a = R1;
            while (R2 < 100)
            {
                S2 = S2 * (1 + (I / 100));
                R2 += S2;
                b++;
            }
            b += 1;

            while (S3 <= 42)
            {
                S3 = S3 * (1 + (I / 100));
                R3 += S3;
                c++;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + E)
            {
                double R = 0;
                double ch = 1;
                double zn = 1;
                int i = 0;
                double elem = (2 * i + 1) * ch / zn;

                while (Math.Abs(elem) >= E)
                {
                    R += elem;
                    i++;
                    ch *= x * x;
                    zn *= i;
                    elem = (2 * i + 1) * ch / zn;
                }
                R += elem;

                SS += R;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                x += h;
            }

            // end

            return (SS, SY);
        }
    }
}

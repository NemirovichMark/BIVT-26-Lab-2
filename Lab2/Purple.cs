using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (int)Math.Pow(p + i * h, 2);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            int numPrev = 1, denPrev = 1;
            int numCurr = 2, denCurr = 1;
            const double eps = 0.0001;
            double diff = Math.Abs((double)numCurr / denCurr - (double)numPrev / denPrev);


            while (diff >= eps)
            {
                int numNext = numPrev + numCurr;
                int denNext = denPrev + denCurr;

                numPrev = numCurr; denPrev = denCurr;
                numCurr = numNext; denCurr = denNext;
                diff = Math.Abs((double)numCurr / denCurr - (double)numPrev / denPrev);

            }
            answer = (double)numCurr / denCurr;
            // end
            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double elem = 1;
            int n = 0;
            while (Math.Abs(elem) > 0.0001)
            {
                elem = b * Math.Pow(q, n);
                n++;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            ulong food = 0;
            ulong grain = 1;
            for (int i = 0; i < 64; i++)
            {
                food += grain;
                grain *= 2;
            }
            ulong gramms = food / 15;
            answer = (long)(gramms / Math.Pow(10, 6));
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int n = 0;
            double doubled = S * 2;
            if (S > 0 && d > 0)
            {
                while (S < doubled)
                {
                    double yearStart = S;
                    for (int i = 0; i < 12 && S < doubled; i++)
                    {
                        S += (d / 1200) * yearStart;
                        n++;
                    }
                }
            }
            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            int n = (int)Math.Floor((b - a) / h + 1e-9);

            // code here
            for (int k = 0; k <= n; k++)
            {
                double x = a + k * h;
                SY += Math.Cos(x);
                double s = 0;
                int i = 0;
                double term = 1;

                while (true)
                {
                    s += term;
                    if (Math.Abs(term) < eps) break;
                    term = -term * x * x / ((2 * i + 1) * (2 * i + 2));
                    i++;
                }
                SS += s;
            }
            // end

            return (SS, SY);
        }
    }
}
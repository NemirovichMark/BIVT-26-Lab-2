using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;

        public double Task1(int n)
        {
            double answer = 0;
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            return answer;
        }

        public double Task2(int n, double x)
        {
            double answer = 1;
            double term = 1.0 / x;
            for (int i = 1; i <= n; i++)
            {
                answer += term;
                term /= x;
            }
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;
            long fsum = 1;
            for (int i = 1; i <= n; i++)
            {
                fsum *= i;
                answer += fsum;
            }
            return answer;
        }

        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;
            double x_pow = x;

            while (true)
            {
                double term = Math.Sin(i * x_pow);
                if (Math.Abs(term) < E)
                {
                    break;
                }
                answer += term;
                i++;
                x_pow *= x;
            }
            return answer;
        }

        public int Task5(double x)
        {
            int answer = 1;
            double prev = 1.0;
            double curr = 1.0 / x;

            while (Math.Abs(curr - prev) >= E)
            {
                answer++;
                prev = curr;
                curr /= x;
            }
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
                L /= 2.0;
                answer++;
            }
            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            int steps = (int)Math.Round((b - a) / h);

            for (int k = 0; k <= steps; k++)
            {
                double x = a + k * h;
                double sumS = 0;
                double term = x;
                int i = 0;

                while (true)
                {
                    sumS += term;
                    if (Math.Abs(term) < 0.0001)
                        break;

                    i++;
                    term *= -1.0 * x * x * (2 * i - 1) / (2 * i + 1);
                }

                SS += sumS;
                SY += Math.Atan(x);
            }
            return (SS, SY);
        }
    }
}

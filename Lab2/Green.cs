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
                double a = i;
                answer += a / (a + 1);
            }

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            for (int i = 0; i <= n; i++)
            {
                int b = -1 * i;
                double a = Math.Pow(x, b);
                answer += a;
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            for (int i = 0; i <= n; i ++)
            {
                long fact = 1;

                for (int j = 1; j <= i; j ++)
                {
                    fact *= j; 
                }

                answer += fact;
            }

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            for (int i = 1; ; i++)
            {
                double s = Math.Pow(x, i);
                double si = Math.Sin(i * s);
                if (Math.Abs(si) < Math.Pow(10, -4))
                {
                    break;
                }
                else
                {
                    answer += si;
                }
            }

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            for (int n = 1; ; n++)
            {
                double a = 1 / Math.Pow(x, n);
                double b = 1 / Math.Pow(x, n - 1);
                if (Math.Abs(a - b) < Math.Pow(10, -4))
                {
                    answer = n;
                    break;
                }
            }
            
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0; int elem = 1;
            for (int i = 0;elem < limit; i++)
            {
                elem *= 2;
                answer += elem;

            }


            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0; int c = 0;

            double Da = Math.Pow(10, -10);
            while (L > Da)
            {
                L /= 2;
                c += 1;
            }
            answer = c;
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

                double row = 0;
                for (int i = 0; ; i++)
                {
                    double s = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);

                    if (Math.Abs(s) < 0.0001)
                        break;

                    row += s;
                }
                SS += row;
                SY += Math.Atan(x);
            }

            return (SS, SY);
        }
    }
}

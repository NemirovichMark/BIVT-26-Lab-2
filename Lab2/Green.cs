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
            double a = 1;

            for (int i = 0; i <= n; i++)
            {
                answer += a;
                a /= x;
            }
            return answer;
        }
        public long Task3(int n)
        {

            long answer = 0;

            for (int i = 0; i <= n; i++)
            {
                long fact = 1;

                for (int j = 1; j <= i; j++)
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

            double s = 1;

            for (int i = 1; ; i++)
            {
                s *= x;
                double si = Math.Sin(i * s);

                if (Math.Abs(si) < E)
                    break;

                answer += si;
            }

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            double b = 1;

            for (int n = 1; ; n++)
            {
                double a = b / x;

                if (Math.Abs(a - b) < E)
                {
                    answer = n;
                    break;
                }

                b = a;
            }


            return answer;
        }
        public int Task6(int limit)
        {

            int answer = 0; int elem = 1;
            for (int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;

            }
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            while (L > Da)
            {
                L /= 2;
                answer++;
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;


            for (double x = a; x <= b + h / 1000; x += h)
            {
                int i = 0;
                double smx = 0;
                double c = x;
                double step = x * x;

                while (true)
                {
                    double term = c / (2 * i + 1);
                    if (i % 2 != 0) term = -term;

                    if (Math.Abs(term) < E)
                    {
                        smx += term;   
                        break;
                    }

                    smx += term;
                    c *= step;
                    i++;
                }

                SS += smx;
                SY += Math.Atan(x);
            }
            return (SS, SY);
        }
    }
}

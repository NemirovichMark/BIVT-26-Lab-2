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

            for (int i = 2; i <= n; i+=2)
            {
                double a = i;
                answer += a/(a+1);
            }

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            for (int i = 0; i <= n; i++)
            {
                answer += (Math.Pow(x, -i));
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            for (int i = 0; i <= n;i++)
            {
                long fc = 1;
                for (int j = 1; j <= i; j++)
                {
                    fc *= j;
                }
                answer += fc;
            }

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;
            double eps = Math.Pow(10, -4);
            while (true)
            {
                double otv = Math.Sin(i * Math.Pow(x, i));
                if (Math.Abs(otv) < eps)
                {
                    break;
                }
                answer += otv;
                i++;
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            double eps = Math.Pow(10, -4);
            int n = 1;
            while (true)
            {
                double dr = 1.0 / Math.Pow(x, n);
                double drr = 1.0 / Math.Pow(x, n-1);
                if (Math.Abs(dr - drr)<eps)
                {
                    answer += n;
                    break;
                }
                n++;
            }

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            int elem = 1;
            int i = 0;
            while (true)
            {
                if (elem >= limit)
                {
                    break;
                }
                elem *= 2;
                answer += elem;
                i++;
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double d = Math.Pow(10, -10);
            while (L > d)
            {
                L /= 2;
                answer++;
            }

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;


            for (double x = a; x <= b+(h/1000); x += h)
            {
                int i = 0;
                double smx = 0;
                while (true)
                {
                    double c = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                    if (Math.Abs(c) < eps)
                    {
                        smx += c;
                        break;
                    }
                    smx += c;
                    i++;
                }
                SS += smx;
                SY += Math.Atan(x);  
            }

            return (SS, SY);
        }
    }
}

using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double sum = 0;
            for (double a = 2; a <= n; a += 2 )
            {
                sum = sum + (a / (a + 1));
            }
            answer = sum;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double sum = 1.0;
            double addend = 1.0;

            for (int k = 1; k <= n; k++)
                { 
                addend /= x;
                sum += addend;
                }
            answer = sum;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long summ = 1;
            long fact = 1;

            for (int k = 1; k <= n; k++)
            {
               fact = fact* k;
               summ += fact;
            }
            answer = summ;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double E = 0.0001;
            double s = 0, a;
            int n = 1;
            double p = x;
            do
            {
                a = Math.Sin(n * p);
                s = s + a;
                n = n + 1;
                p = p * x;
            } while (Math.Abs(a) > E); 
            answer = s;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double E = 0.0001;
            double per = 1.0 / x;
            double vt = 1.0;

            while (Math.Abs(per - vt) > E)
            {
                n++;
                vt = per;
                per /= x;
            } 
            answer = n;


            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;

            while (elem < limit)
            {
                elem *= 2;
                answer = answer + elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int i = 0;
            double Da = 0.0000000001;
            while (L > Da)
            {
                L = L / 2.0;
                i++;
            }
            answer = i;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double E = 0.0001;
            for (double x = a; x <= b + 1e-10; x += h)
            {
                double term = x; 
                double S = 0;
                int i = 0;

                while (Math.Abs(term) > E)
                {
                    S += term;
                    term = -term * x * x * (2.0 * i + 1)/ (2.0 * i + 3);
                }
                SS += S;
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}
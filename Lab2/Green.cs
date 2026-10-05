using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

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
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double term = 1;

            for (int i = 1; i <= n; i++)
            {
                term /= x;
                answer += term;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fac = 1;
            answer = 1;

            for (long i = 1; i <= n; i++)
            {
                fac *= i;
                answer += fac;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            int n = 1;
            double s = 1.0;
            // code here
            double pw = x;
            s = Math.Sin(n * pw);

            while (Math.Abs(s) >= E)
            {
                answer += s;
                n++;
                pw *= x;
                s = Math.Sin(n * pw);
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double prev = 1;
            double cur = 1 / x;
            answer = 1;

            while (Math.Abs(cur - prev) >= E)
            {
                prev = cur;
                cur /= x;
                answer++;
            }
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
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double length = L;

            while (length > Da)
            {
                length /= 2;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            // code here
            for (int k = 0; a + k * h <= b; k++)
            {
                double x = a + k * h;
                double s = 0;
                double term = x;
                int i = 0;

                while (true)
                {
                    s += term;

                    if (Math.Abs(term) < E)
                        break;

                    i++;
                    term = -term * x * x * (2 * i - 1) / (2 * i + 1);
                }

                SS += s;
                SY += Math.Atan(x);
            }
            //end

            return (SS, SY);
        }
    }
}
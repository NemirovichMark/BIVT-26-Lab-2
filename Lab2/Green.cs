using System.Collections.Generic;
using System.Security.Cryptography;
using System.Transactions;

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
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += i / (i + 1.0);
                }
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double current = 1.0;
            for (int i = 1; i <= n; i++)
            {
                current /= x;
                answer += current;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long current = 1;
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                current *= i;
                answer += current;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double Power = x;
            while (true)
            {
                double part = Math.Sin(n * Power);
                if (Math.Abs(part) < E)
                {
                    break;
                }
                answer += part;
                n++;
                Power *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double a1 = 1.0;
            double previous = 1.0;
            for (int n = 1; ; n++)
            {
                a1 /= x;
                if (Math.Abs(a1 - previous) < E)
                {
                    answer = n;
                    break;
                }
                previous = a1;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
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
            int n = 0;
            for (; L > Da; n++)
            {
                L /= 2;
            }
            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + (h / 2); x += h)
            {
                double s = 0;
                double num = x;
                int i = 0;
                while (true)
                {
                    int znamenatel = 2 * i + 1;
                    double one_of = num / znamenatel;
                    if (Math.Abs(one_of) < E)
                    {
                        break;
                    }
                    s += one_of;
                    i++;
                    num *= -1.0 * x * x;
                }
                SS += s;
                SY += Math.Atan(x);

            }
            // end

            return (SS, SY);
        }
    }
}

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
            double a = 1.0;
            for (int i=0;i<n;i++)
            {
                answer = answer + Math.Sin((i+1) * x) / a;
                a = a * x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            //code here
            double power = 1;
            for (double i = 1, fact = 1; i <= n; i++)
            {
                fact *= i;
                power *= 5;
                if (i % 2 == 0)
                {
                    answer = answer + (power / fact);
                }
                else
                {
                    answer = answer - (power / fact);
                }


            }

            //int power = 5;
            //int ch = -1;
            //int zn = 1;
            //for (int i = 1; i < n + 1; i++)
            //{
            //    answer += ch * power / zn;
            //    ch *= -1;
            //    power *= 5;
            //    zn *= i;
            //}
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int first = 0;
            int second = 1;
            int a = 0;

            for (int i = 0; i < n; i++)
            {
                answer += first;
                a = first + second;
                first = second;
                second = a;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;

            for (int n = 1; n < 10_000; n++)
            {
                int b = a + (n - 1) * h;

                if (s + b <= L)
                {
                    s += b;
                    answer = n;
                }
                else break;
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

            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;

                if (elem > 0.0001)
                {
                    continue;
                }
                else break;
            }
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int schet = 0;
            while (S < L)
            {
                S = S * 2;
                schet = schet + 1;
            }
            answer = schet * h;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double totale = S;
            double daily = S;
            for (int day = 1; day < 10000; day++)
            {
                if (day == 7 )
                {
                    a = totale;
                }
                if (totale >= 100 && b==0)
                {
                    b = day;
                }
                if (daily > 42 && c==0)
                {
                    c = day;
                }
                daily += daily / 100 * I;
                totale += daily;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.000000001; x += h)
            {
                double fact = 1;
                double pow = 1;
                double s = 0;

                for (int i = 0; i < 10_000; i++)
                {
                    if (i > 0)
                    {
                        fact *= i;
                        pow *= x * x;
                    }

                    double r = (2 * i + 1) * pow / fact;
                    s += r;

                    if (Math.Abs(r) < E) break;
                }

                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                answer += (int)Math.Pow((p + i * h), 2);
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            while (a / b * b != a)
            {
                a--;
                remainder++;
            }
            quotient = a / b;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            double epsi = Math.Pow(10, -4);
            int a = 1;
            int b = 1;
            int c;
            double d;
            int lol = 1;
            while (true)
            {
                d = a / b;
                c = a;
                a = a + b;
                b = c;
                lol++;
                if (Math.Abs(d - a / b) < epsi)
                {
                    answer = lol;
                    break;
                }
            }

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            int n = 0;
            double epsi = Math.Pow(10, -4);
            do
            {
                n++;
            } while (b * Math.Pow(q, n) < epsi);
            answer = n;
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
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
            

            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            for (int i = 0; i < 64; i++)
            {
                answer += (long)Math.Pow(2, i);
            }
            answer = (long)(answer * 15 / 1000.0);

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            int mon = 0;
            double S1 = S;
            double k = (d / 12 + 100) / 100;
            do
            {
                S1 *= k;
                mon++;
            } while (S1 >= S * 2);
            answer = mon;

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double epsi = Math.Pow(10, -4);

            double SS = 0;
            double SY = 0;
            int i = 0;
            for (double x = a; x < b; x += h)
            {
                double S = 0;
                i = 0;
                while (Math.Pow(-1, i) * Math.Pow(x, 2 * i) / (2 * i)! < epsi)
                {
                    S += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / (2 * i)!;
                } 
            }

            return (SS, SY);
        }
    }
}
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
            double a = 1;
            double b = 1;
            double c;
            double pre;
            while (true)
            {
                pre = a / b;
                c = a;
                a += b;
                b = c;
                if (Math.Abs(pre - a / b) < epsi)
                {
                    answer = a / b;
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
            } while (Math.Abs(b * Math.Pow(q, n)) >= epsi);
            answer = n + 1;
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
            ulong answer = 0;
            for (int i = 0; i < 64; i++)
            {
                answer += (ulong)Math.Pow(2, i);
            }
            answer = answer / 15000000;

            return (long)answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double k = (d / 100.0) / 12.0;
            double shi = S * k;
            double target = 2 * S;

            for (int i = 1; S < target; i++)
            {
                S += shi;
                if (i % 12 == 0 && i != 0)
                {
                    shi = S * k;
                }
                answer = i;
            }
            
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double epsi = Math.Pow(10, -4);

            double SS = 0;
            double SY = 0;
            int i = 0;
            double gowno;
            double S;
            double wow;
            int astralstep = (int)((b - a) / h);
            for (int step = 0; step <= astralstep; step++) // будь ты проклят доубле утконос
            {
                double x = a + step * h;
                S = 0;
                i = 0;
                while (true)
                {
                    gowno = 1;
                    wow = 0;
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        gowno *= j;
                    }
                    wow = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / gowno;
                    S += wow;

                    if (Math.Abs(wow) < epsi)
                    {
                        break;
                    }
                    i += 1;
                }
                SS += S;
                SY += Math.Cos(x);
            }



            return (SS, SY);
        }
    }
}
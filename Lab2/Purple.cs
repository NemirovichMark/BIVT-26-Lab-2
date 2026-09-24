using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            int add=0;
            int s=1;
            for (int i = 1; i < n; i++)
            {
                s = (p + h * i) * ( p + h * i);
                add += s;
            }

            answer = p * p + add;

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            int s=0;
            for (int i=0;a>=b ; a=a-b)
            {
                s++;
            }
            quotient = s;
            remainder = a;
            
            
            
            
            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            double a = 2.0;
            double a1 = 1.0;
            double b = 3.0;
            double b1 = 2.0;
            for (int i=0; Math.Abs(a / a1 - b / b1) > 1 / 10000;)
            {
                a = a + b;
                a1 = a1 + b1;
                b += a;
                b1 += a1;
            }
            answer=a/a1;

            

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double s=1;
            double q1 = q;
            for (int i = 2;Math.Abs(s)>1.0/10000; i++)
            {
                s = b * q;
                q = q * q1;
                answer = i;
            }
            
            
            
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
            ulong a = 1;
            ulong b = 0;
            
            for (int i = 1; i <64; i++)
            {
                b += a;
                a = a * 2;
            }

            b = (b+a) / 15;
            b = b/ (1000 * 1000);
            answer = (long)b;
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            d = d / 100;
            double s1 = S;
            double m = d / 12;
            double s2 = S * m;
            for (int i=1; S / s1 < 2;i++)
            {
                if (i % 12 == 0)
                {
                    s2 = S * m;
                }
                S = S + s2;
                answer = i;
            }
            
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            for (int i1=0; a+i1*h <= b; i1++)
            {
                double x = a + h*i1;
                int i = 0;
                double chlen = 1;
                double s = chlen;
                while (Math.Abs(chlen)>=eps)
                {
                    chlen *= -x * x / ((2.0 * i + 1) * (2.0 * i + 2));
                    s += chlen;
                    i++;
                }

                SS += s;
                SY += Math.Cos(x);
            }

            

            return (SS, SY);
        }
    }
}

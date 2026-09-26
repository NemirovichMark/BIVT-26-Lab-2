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
            

            for (int i = 0; i < n; i++)
            {
                answer += (p + (i * h)) * (p + (i * h));
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 1;
            int remainder = 0;

            if (a != b)
            {
                while (a >= b)
                {
                    a -= b;
                    quotient ++;
                }
                quotient -= 1;
                remainder = a;
            }
            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            int ch = 1;
            int zn = 1;
            int ch1 = 2;
            int zn1 = 1;
            while (Math.Abs((double)ch1 / zn1 - (double)ch / zn) >= E)
            {
                ch += ch1;
                ch1 += ch;
                zn += zn1;
                zn1 += zn;
            }
            if (((double)ch1 / zn1) > ((double)ch / zn))
            {
                answer = (double)ch1 /zn1;
            }
            else
            {
                answer = (double)ch / zn;
            }

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            while (Math.Abs(b) >= E)
            {
                b *= q;
                answer ++;
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
                b --;
            }
            while (number >= 10)
            {
                number /= 10;
                answer ++;
            }
            
            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            long zerno = 0;
            long z = 1;
            for (int i = 0; i < 63; i++)
            {
                zerno += z;
                z *= 2;
            }
            answer = zerno / 7500000;
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double S2 = S;
            double d2 = S*d/100;

            while (S < S2*2)
            {
                if (answer % 12 == 0)
                {
                    d2 = S * d / 100;
                }
                S += d2/12;
                answer ++;
            }
            
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}

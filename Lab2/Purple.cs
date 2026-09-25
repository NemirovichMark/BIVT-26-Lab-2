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

            // code here
            int s = p*p;
            for (int I=1;I<n;I++)
                s += Math.Pow(p+I*h,2);
                
            answer = s;

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = a;

            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a = 1;
            double b = 2;
            double c = 1;
            double d = 2;

            while (Math.Abs(d - c) >= E)
            {
                double x = a + b;

                a = b;
                b = x;
                c = d;
                d = b / a;
            }

            answer = d;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double x = b;
            answer = 1;

            while (Math.Abs(x) >= E)
            {
                 x = x * q;
                 answer++;
            }

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

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

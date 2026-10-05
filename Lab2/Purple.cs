using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
            int sum = 0;
            for (int i = 0; i < n; i += 1)
                sum += (p + i * h) * (p + i * h);
            // end

            answer = sum;
            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double ch1 = 1;
            double ch2 = 1;
            double ch = ch1 + ch2;
            double zn1 = 0;
            double zn2 = 1;
            double zn = zn1 + zn2;
            double full = ch / zn;
            while (true)
            {
                ch1 = ch2;
                ch2 = ch;
                ch = ch1 + ch2;
                zn1 = zn2; 
                zn2 = zn; 
                zn = zn1 + zn2; 
                if (Math.Abs(full - ch / zn) < 0.0001)
                    break;
                full = ch / zn; 
            }
            answer = full;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double num = b;
            int cnt = 1;
            // code here
            while (Math.Abs(num) >= E)
            {
                cnt++;
                num *= q;
            }
            answer = cnt;
            // end  

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
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
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            double sum = 1;
            double two = 1;
            for (int i = 1; i <= 63; i++)
            {
                two *= 2;
                sum += two;
            }
            double inTons = sum / 15 / 1000000;
            answer = (long)Math.Floor(inTons);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double currentS = S;
            double yearStart = S;
            int month = 0;
            double monthly = d / 100 / 12;
            while (currentS < (S * 2))
            {
                if (month % 12 == 0)
                {
                    yearStart = currentS;
                }
                currentS += yearStart * monthly;
                month++;
            }
            answer = month;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int stepsAmt = (int)((b - a) / h);

            for (int i = 0; i <= stepsAmt; i++)
            {
                double x = a + i * h;

                double sum = 0;
                double t = 1;
                int j = 0;

                while (Math.Abs(t) >= E)
                {
                    sum += t;
                    j++;
                    t = -t * x * x / ((2 * j - 1) * (2 * j));
                }

                SS += sum;
                SY += Math.Cos(x);
            }

            return (SS, SY);
        }
    }
}

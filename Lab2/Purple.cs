using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            int midpoint;
            for (int i=1; i <= n; i++)
            {
                //Console.WriteLine(i);
                midpoint = (p+(i-1)*h);
                midpoint *= midpoint;
                answer += midpoint;
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (b <= a)
            {
                ++quotient;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            int a1 = 2;
            int a2 = 3;
            int b1 = 1; 
            int b2 = 2;
            double s = 1 / (double)10000;
            while (Math.Abs(a1 / (double)b1 - a2 / (double)b2) > s){
                int c1 = a2;
                int c2 = b2;
                a2 += a1;
                b2 += b1;
                a1 = c1;
                b1 = c2;
                answer = c1 / (double)c2;
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double s = 1 / (double)10000;
            while (Math.Abs(b) >= s){
                answer++;
                b *= q;
            }
            answer++;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
            while (b>0)
            {
                number *= b;
                b--;
            }
            while (number>=10)
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
            long pwr = 1;
            for (int i=1; i < 64; i++)
            {
                answer += pwr;
                pwr *= 2;
            }
            answer /= 15*500000;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double sum=S;
            double monthly = 0;
            while (sum < (S * 2)) {
                if (answer % 12 == 0)
                {
                    monthly = sum * d/100 /12;
                }
                answer++;
                sum += monthly;
            } 

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double es = 0.0001;
            for(double x=a; x<=b+es; x += h)
            {
                double pwr = 1, s = 1, f;
                int i = 0;
                SS++;
                do {
                    pwr *= -x*x;
                    s *= ++i * ++i;
                    f = pwr / s;
                    SS += f;
                }
                while (Math.Abs(f) >= es);
                SY += Math.Cos(x);
            }
            // end
            Console.WriteLine($"SS:{SS} SY:{SY}");
            return (SS, SY);
        }
    }
}
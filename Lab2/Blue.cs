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
            double power = 1;
            int num = 1;
            int t = n;
            while (n > 0)
            {
                answer += (Math.Sin(num * x)) / (power);
                num++;
                power *= x;
                n -= 1;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double five = 5;
            double fact = 1;
            double lastFact = 1;
            int znak = -1;
            while (n > 0)
            {
                answer += (znak *( five / fact));
                lastFact += 1;
                fact *= lastFact;
                znak *= -1;
                five *= 5;
                n -= 1;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int ch1 = 0;
            int ch2 = 1;
            int ch3=0;
            if (n == 1)
            {
                answer = 0;
                n -= 1;
            }
            else
            {
                while (n > 0)
                {
                    answer += ch1;
                    ch3 = ch1 + ch2;
                    ch1 = ch2;
                    ch2 = ch3;
                    n -= 1;
                }
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            // code here
            int n = 0;
            int cnt = 0;
            while (cnt+(a+n*h)<=L)
            {
                cnt +=( a + n * h);
                answer += 1;
                n += 1;
            }

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem=ch/zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = (ch / zn);
                i++;
            } while (elem > 0.0001);
         
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S<L)
            {
                answer+=h;
                S *= 2;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            int day = 7;
            double sum=0;
            double x = S;
            while (day>0)
            {
                a+= S;
                S+=(S*I/100);
                day -= 1;
            }
            S = x;
            while (sum<100)
            {
                sum += S;
                S += (S * I / 100);
                b += 1;
            }
            S = x;
            while(S<42)
            {
                S += (S * I / 100);
                c += 1;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int steps = (int)Math.Floor((b - a) / h + 1e-9);
            for (int k = 0; k <= steps; k++)
            {
                double x = a + k * h;
                double Pow = 1;
                double fact = 1;
                double ch;
                double s = 0;
                int i = 0;
                do
                {
                    ch = (2 * i + 1) * Pow / fact;
                    s += ch;
                    i++;
                    Pow *= x * x;
                    fact *= i;
                } while (Math.Abs(ch) >= 0.0001);

                SY += (1 + 2 * x * x) * Math.Exp(x * x);

                SS += s;
            }
                // end

             return (SS, SY);
                
            
        }
    }
}

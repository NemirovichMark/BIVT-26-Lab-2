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
            double sl = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(x * i)/sl;
                sl *= x;

            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            // code here
            double zn = -1;
            double f = 1;
            double st = 5;
            for (int i = 1; i <= n; i++)
            {
                answer += zn * st / f;
                zn *= -1;
                f *= (i + 1);
                st *= 5;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        { 
            int t = 0;
            int p = 1;
            int s = 0;

            // code here
            for (int i = 0;i < n; i++)
            {
                s += t;
                int nextf = t + p;
                t = p;
                p = nextf;
            }
            // end 

            return s;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int n = 0;
            int sum = 0;
            // code here
            while (sum <= L)
            { 
                sum += a + (h * n);          
                n++;
            }
            answer = n-1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;

            // code here

            do 
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;

            } while (elem > 0.0001);
              Console.WriteLine(answer);


            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            do
            {
                S *= 2;
                answer+= h;
            } while (S < L);

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            double sumProc = S;
            // code here
            for (int i = 1; i <= 7; i++)
            {
                a += sumProc;
                sumProc *= (100 + I ) / 100;
            }

            sumProc = S;
            double sum = 0;
            while (sum <= 100)
            {
                sum += sumProc;
                sumProc *= (100 + I) / 100;
                b++;
            }
            sumProc = S;
            while (sumProc <= 42)
            { 
                sumProc *= (100 + I) / 100;
                c++;
            }
            


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (double x = a; Math.Round(x, 5) <= b; x += h) 
            {
                double s = 0;
                double elem = 1;
                double pow = 1;
                double fact = 1;
                int i = 0;
                while (Math.Abs(elem) > E)
                {
                    elem = ((2 * i + 1) * pow) / fact;
                    s += elem;
                    pow *= x * x;
                    i++;
                    fact *= i;
                }
                SS += s;

                SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
            }
            // end

            return (SS, SY);
        }
    }
}
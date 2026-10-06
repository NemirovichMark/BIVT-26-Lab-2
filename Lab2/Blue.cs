using System;
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
            for (int i = 1; i <= n; i++)
                answer += Math.Sin(x * i) / Math.Pow(x, i - 1);
            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double power = 1.0;
            double fact = 1.0;
            for (int i = 1; i <= n; i++)
            {
                power *= 5.0;
                fact *= i;
                double term = power / fact;
                if (i % 2 == 1)
                    answer -= term;
                else
                    answer += term;
            }
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                long temp = a + b;
                a = b;
                b = temp;
            }
            // end

            return answer;
        }

        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0;
            int term = a;
            while (true)
            {
                if (sum + term > L)
                    break;
                sum += term;
                answer++;
                term += h;
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

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            long cells = S;
            int time = 0;
            while (cells < L)
            {
                cells *= 2;
                time += h;
            }
            answer = time;
            // end

            return answer;
        }

        public (double a, int b, int c) Task7(double S, double I)
        { // code here
           double a = 0; 
           double leng = 0; 
           double k = 1 + I / 100; 
           double norm = S; int b = 0;
           int c = 0; 
           for (int i = 0; i < 7; i++) 
           { a += norm; 
           norm *= k; }
            norm = S;
            while (leng < 100)
            {
                leng += norm;
                norm *= k;
                b++;
            }

            norm = S;
            while (norm <= 42)
            {
                norm *= k;
                c++;
            }

            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            for (double x = a; x <= b + h / 10; x += h)
            {
                double Sx = 0;
                int i = 0;
                double termBase = 1;

                while (true)
                {

                    double term = (2 * i + 1) * termBase;
                    Sx += term;


                    if (Math.Abs(term) < eps)
                    {
                        break;
                    }

                    i++;
                    termBase *= (x * x) / i;
                }

                SS += Sx;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            return (SS, SY);
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double w = 1;
            for(int i = 1; i < n+1; i++)
            {
                answer = answer + Math.Sin(i * x) / w;
                w *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for(int i = 1; i < n + 1; i++)
            {
                double factorial = 1;
                for(int k = 1; k < i+1; k++)
                {
                    factorial = factorial * k;
                }
                answer = answer + (Math.Pow(-1, i)*Math.Pow(5,i))/factorial;
            }
            
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fibnum1 = 1;
            long fibnum2 = 1;
            long fibnumreserve = 0;
            
            for(int i = 0; i < n; i++)
            {
                if (i == 1 || i == 2)
                {
                    answer += 1;
                }
                else if (i == 0)
                {
                    answer = 0;
                }
                else
                {
                    answer = answer + fibnum1 + fibnum2;
                    fibnumreserve = fibnum1 + fibnum2;
                    fibnum1 = fibnum2;
                    fibnum2 = fibnumreserve;
                }
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int summa = 0;
            // code here

            while (summa <= L)
            {
                summa = summa + a + h * answer;
                answer++;
            }
            // end

            return answer-1;
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
            } while (elem>0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                S *= 2;
                answer += h;
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
            double curDay = S;
            for (int i = 0; i < 7; i++)
            {
                a = a + curDay;
                curDay += (curDay / 100) * I;
            }
            double summ100 = 0;
            curDay = S;
            while (summ100 < 100)
            {
                summ100 += curDay;
                curDay += (curDay / 100) * I;
                b++;
            }
            curDay = S;
            while (curDay < 42) 
            {
                curDay += (curDay / 100) * I;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double e = 0.00001;

            // code here
            
            for (double x = a; x <= b + e; x += h)
            {
                double summofrow = 0;
                double curChlen = 1;
                int i = 0;
                while (Math.Abs(curChlen) >= e)
                {
                    summofrow += curChlen;
                    i++;
                    curChlen *= (2.0 * i + 1) / (2.0 * i - 1) * (x * x) / i;
                }
                double Y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += summofrow;
                SY += Y;
            }
            
            // end

                return (SS, SY);
        }
    }
}

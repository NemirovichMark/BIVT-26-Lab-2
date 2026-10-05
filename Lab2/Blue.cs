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
            double d = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(x * i) / d;
                d = d*x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double element = 1;
            for (int i = 1; i <= n; i++)
            {
                element *= -5.0 / i;
                answer += element;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                if (i < n - 1)
                {
                    long next = a + b;
                    a = b;
                    b = next;
                }
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long sum = 0;
            int k = 0;
            long element = a + h*k;
            while (sum + element <= L)
            {
                sum = sum + element;
                answer += 1;
                k += 1;
                element = a + h * k;
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
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            long sum = S;
            while (sum <= L)
            {
                answer += h;
                sum *= 2;
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
            double sput1 = S;
            for (int i = 1; i <= 7; i++)
            {
                a += sput1;
                sput1 = sput1 + sput1 * I/100;
            }
            double sput2 = S;
            double sum1 = 0;
            while (sum1 < 100)
            {
                sum1 += sput2;
                b += 1;
                sput2 += sput2 * I/100;
            }
            double sput3 = S;
            c = 0;
            while (sput3 <= 42)
            {
                sput3 += sput3 * I/100;
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
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double power = 1;
                double factorial = 1;
                double elem = 1;
                double S = 1;
            while (Math.Abs(elem) >= 0.0001)
                {
                    i++;
                    power *= x * x;
                    factorial *= i;
                    elem = (2 * i + 1) * power / factorial;
                    S += elem;
                }
                SS += S;
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;
            }

            // end

            return (SS, SY);
        }
    }
}

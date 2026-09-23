using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double xi = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / xi;
                xi *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n) 
        {
            double answer = 0;

            // code here
            int sign = -1;
            long fact = 1;
            double five = 5;

            for (int i = 1; i <= n; i++)
            {
                answer += sign * five / fact;
                sign *= -1;
                fact *= (i + 1);
                five *= 5;
            }
            // end

            return answer;
        }

        // фибоначчи - число равно сумме двух предыдущих
        public long Task3(int n) 
        {
            long answer = 0;

            // code here
            if (n <= 1)
            {
                answer = 0;
            }
            else
            {
                long summ = 0;
                long a = 0;
                long b = 1;

                for (int i = 0; i < n; i++)
                {
                    summ += a;
                    long temp = a;
                    a = b;
                    b += temp;
                }
                answer = summ;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double summ = 0;
            double first = a;
            for (int i = 0; ;i++)
            {
                if (summ + first > L) { break; }
                summ += first;
                answer++;
                first += h;
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
            do
            {
                S *= 2;
                answer += h;
            } while (S <= L);
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            // code here
            double a = 0;
            int b = 0;
            int c = 0;
            ///
            double add = 1 + (I / 100.0);
            double currentA = S;
            double totalA = 0;
            double currentB = S;
            double totalB = 0;
            double currentC = S;

            for (int day = 1; day < 8; day++)
            {
                totalA += currentA;
                currentA *= add;
            }
            a = totalA;

            while (totalB < 100)
            {
                b++;
                totalB += currentB;
                currentB *= add;
            }

            if (S > 42) { c = 0; }
            else
            {
                while (currentC <= 42)
                {
                    currentC *= add;
                    c++;
                }
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double eps = 0.0001;
            for (double x = a; x <= b+h/10; x += h)
            {
                double sx = 0;
                int i = 0;
                double term1 = 1;
                while (true)
                {
                    double term = (2 * i + 1) * term1;
                    sx += term;
                    if (Math.Abs(term) < eps) break;
                    i++;
                    term1 *= (x * x) / i;
                }
                SS += sx;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            

            // end

            return (SS, SY);
        }
    }
}

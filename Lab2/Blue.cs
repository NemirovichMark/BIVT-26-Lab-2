using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
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
            double s = 0;
            double x1 = 1;
            for (int i = 1; i <= n; i++)
            {
                s += Math.Sin(i * x) / x1;
                x1 = x1 * x;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int z = -1;
            double x = 5;
            double n1 = 1;
            double A = 0;
            for (int i = 1; i <= n; i++)
            {
                n1 *= i;
                A += z * (x / n1);
                z *= -1;
                x *= 5;
            }
            answer = A;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int z = 0;
            int y = 1;
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                answer += z;
                r = z + y;
                z = y;
                y = r;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int ans = 0;
            int n = 0;
            while (ans + (a + ((n + 1) - 1) * h) <= L) 
            {
                n++;
                ans += (a + (n - 1) * h);
            }
            answer = n;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
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
            int x = 0;
            int o = 0;
            for (int i = h; S < L; i += h)
            {
                x = S * 2;
                S = x;
                o = i;
            }
            answer = o;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            a = 0;
            b = 0;
            c = 0;
            int day = 1;
            double V = S;
            double q = 0;
            while (day <= 7)
            {
                a += V;
                V = V * (I/ 100.0 + 1);
                day++;

            }
            if (a < 100)
            {
                q = a;
                while (q < 100)
                {
                    q += V;
                    V =  V * (I / 100.0 + 1);
                    b = day;
                    day++;
                 

                }
            }
            else
            {
                double t = 0;
                double speed = S;
                while (t < 100)
                {
                    b++;
                    t += speed;
                    speed = speed * (1 + I / 100.0);
                    
                }
            }
            V = S;
            c = 0;
            while (V <= 42)
            {
                V = V * (1 + I / 100.0);
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            //code here
            int n = (int)((b - a) / h + 0.000001);
            for (int k = 0; k <= n; k++)
            {
                double x = a + k * h;
                double s = 0;
                double c = 1;
                int i = 0;
                do
                {
                    s += c;
                    i++;
                    c = c * x * x / i * (2 * i + 1) / (2 * i - 1);
                }
                while (Math.Abs(c) >= E);
                s += c;
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;
            }
            //end
            return (SS, SY);
        }
    }
}
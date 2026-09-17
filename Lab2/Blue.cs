using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    
    
    public class Blue
    {
        public static long Fact(long n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Fact(n - 1);
        }
        
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(i * x)) / (Math.Pow(x, i - 1));
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double ans = 0;

            // code here
            
            for (int i = 1; i <= n; i++)
            {
                ans += (Math.Pow(-1, i) * ((Math.Pow(5, i)) / (Fact(i))) );
            }
            // end

            return ans;
        }
        public long Task3(int n)
        {
            long sum = 0;
            long a = 0, b = 1;
            
            // code here
            
            for (int i = 0; i < n; i++)
            {
                sum += a;
                long next = a + b;
                a = b;
                b = next;
            }
            // end

            return sum;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int n = 0;

            // code here
            
            while (answer + a + n * h <= L)
            {
                answer += a + n * h;
                n++;
            }
            
            // end
            
            return n;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0, zn = 1;
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
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            long cells = S;

            // code here
            while (cells < L)
            {
                cells *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            double leng = 0;
            double k = 1 + I / 100;
            double norm = S;
            int b = 0;
            int c = 0;

            // code here
            for (int i = 0; i < 7; i++)
            {
                a += norm;
                norm *= k;
            }

            norm = S;
            while (leng < 100)
            {
                leng += norm;
                norm *= k;
                b++;
            }

            norm = S;
            c = 0;

            while (norm <= 42)
            {
                norm *= k;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            // code here
            double x = a;

            while (x <= b + 0.0000001)
            {
                double s = 0;
                double t = 1;
                double fact = 1;
                double st = 1;
                int i = 0;

                while (Math.Abs(t) >= eps)
                {
                    t = (2 * i + 1) * st / fact;
                    s = s + t;

                    i = i + 1;
                    fact = fact * i;
                    st = st * x * x;
                }
                
                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS = SS + s;
                SY = SY + y;

                x = x + h;
            }
            // end
            return (SS, SY);
        }
    }
}

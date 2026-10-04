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
            double stepen = 1;
            for (int i = 1; i <= n; i++)
            {
                answer+= (Math.Sin(x*i) )/stepen;
                stepen *= x;
            
            }
            // end
            return answer;

        }
        public double Task2(int n)
        {
            double answer = 0;
            

            // code here
            double f = 1;
            double stepen1 = -1;
            double stepen5 = 5;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                answer += (stepen1*stepen5)/f;
                stepen1 *= -1;
                stepen5 *= 5;
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
            
            
            if (n<=0) return 0;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                long c = a + b;
                a = b;
                b = c;
            }
            
            
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            
            
            // code here
            int s = 0;
            while (s + (a + answer * h) <= L)
            {
                s += (a + answer * h);
                answer++;
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
                answer += h;
                S *= 2;

            } while (S < L);
            
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            int days = 1;
            double path = S;
            double allPath = S;

            if (path > 42) c = 1;
            if (allPath >= 100) b = 1;
            
            do
            {
                
                if (days == 7)
                {
                    a = allPath;
                }
                days++;
                path *= (1 + I / 100);
                allPath += path;
                if (b==0 && allPath >= 100)
                {
                    b = days;
                }

                if (c == 0 && path > 42)
                {
                    c = days-1;
                }

            } while (days<=7|| allPath < 100 || path <= 42);

            if (S > 42)
                c = 0;
            
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            // code here
            double bR = Math.Round(b, 9);         

            for (int k = 0; ; k++)                
            {
                double x = a + k * h;             
                if (Math.Round(x, 9) > bR) break; 

                
                double s = 0;                     
                double f = 1;                     
                int i = 0;
                double s1;

                do
                {
                    s1 = (2 * i + 1) * Math.Pow(x, 2 * i) / f;
                    s += s1;                    
                    i++;
                    f *= i;                       
                }
                while (Math.Abs(s1) >= E);    

                SS += s;                          

               
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;
            }
            
            // end

            return (SS, SY);
        }
    }
}
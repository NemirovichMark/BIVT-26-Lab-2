using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double p = 1.0;
            for (int i = 0; i <= n; i++)
            {
                answer += p;
                p /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    factorial *= i;
                }
                answer += factorial;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double xp = x;
            double current;
            do
            {
                current = Math.Sin(n * xp);
                answer += current;
                n++;
                xp *= x;
            } while (Math.Abs(current) >= E);
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int  n = 1;
            double t = 1.0 / x;
            while (Math.Abs(t - t * x) >= E)
            {
                n++;
                t /= x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int el = 1;
            int i = 0;
            while (el < limit)
            {
                el *= 2;
                answer += el;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2.0;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            
            


            for (double x = a; x <= b + 1E-9; x += h)
            {
                
                SY += Math.Atan(x);
    
                
                double s = 0;
                int i = 0;

                
                int sign = 1;

                
                double x2 = x * x;

                
                double number = x;

                while (true)
                {
                    
                    s += sign * number;

                    
                    sign = -sign;

                    
                    if (number < E)
                        break;
                    i++;

                    
                    number *= x2 * (2 * i - 1) / (2 * i + 1);
                }

                SS += s;
            }
            // end

            return (SS, SY);
        }
    }
}
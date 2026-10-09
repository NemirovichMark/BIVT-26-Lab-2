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
            double s = 0;
            for (double i =2; i<=n; i+=2)
            {
                
                s += i / (i + 1);
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double a = x;
            for (int i = 1; i <= n; i++)
            {
                s += 1 / a;
                a = a * x;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            long a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= i;
                s += a;

            }
            answer = s;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            int a = 1;
            double p = x;
            while (Math.Abs(Math.Sin(a*p)) >= E)
            {
                s += Math.Sin(a*p);
                a++;
                p = p * x;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double a = x;
            double st = a;
            double ed = 1.0;
            while (Math.Abs(1.0/st-1.0/ed) >= E)
            {
                n++;
                a *= x;
                ed = st;
                st = a;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            // code here
            for (int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            
            // code here
            while(L > Da)
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
            for (double x = a; x<=b + (h*0.001); x+=h)
            {
                int o = -1;
                double tp = x;
                
                for (int i = 0; ; i++)
                {
                    double bm = 2 * i + 1;
                    o *= -1;
                    double t = o * tp / bm;
                    
                    
                    SS += t;
                    tp *= x * x;
                    if (Math.Abs(t) <= E)
                    {
                        break;

                    }
                }
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}

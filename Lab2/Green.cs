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
            double sum = 0.0;
            for (double i = 2;i<=n;i=i+2)
            {
                sum = sum + (i / (i + 1));
            }
            answer = sum;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double sum=1.0;
            double a=1;
            for(int i=1;i<=n;i++)
            {
                a /= x;
                sum += a;
            }
            answer = sum;
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long sum = 1;
            long a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *=i;
                sum += a;
            }
            answer = sum;

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double s = 0.0;
            double e = 1e-4;
            int n = 1;
            double st = x; 

            while (true)
            {
                double a = n * st;
                double cur = Math.Sin(a);

                if (Math.Abs(cur) < e)
                {
                    break;
                }

                s += cur;
                st *= x; 
                n++;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double e = 1e-4;
            int n = 1;
            double pf = 1.0;
            double cf = 1.0 / x;
            while(Math.Abs(cf-pf)>=e)
            {
                n++;
                pf = cf;
                cf /= x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int e = 1, i = 0;
            while (e < limit)
            {
                e *= 2;
                answer+= e;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double d = 1e-10;
            int c = 0;
            while (L > d) 
            {
                L /= 2.0;
                c++;
            }
            // end
            answer = c;
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double eps = 1e-10;


            double SS = 0;
            double SY = 0;
            int maxIterations = 100000;

            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0;
                double term = x;
                int i = 0;

                do
                {
                    s += term;
                    i++;
                    term = -term * x * x * (2 * i - 1) / (2 * i + 1);
                    if (i > maxIterations) break;
                } while (Math.Abs(term) >= eps);

                double y = Math.Atan(x);

                SS += s;
                SY += y;
            }

            return (SS, SY);
        }
    }
}

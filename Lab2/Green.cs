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
            double j = 3;
            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer = answer + (i / j);
                j += 2;
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 1;

            // code here
            if (x != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    answer += Math.Pow(x, -i);
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            long fac = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
                answer += fac;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) < 1)
            {
                for (int i = 1; ; i++)
                {
                    double arg = Math.Sin(i * Math.Pow(x, i));
                    
                    
                    if (Math.Abs(arg) < E) 
                    { break; }
                    else { answer += arg; }
                }
                
             
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                for (int n = 0; ; n++)
                {
                    double arg = (1 / Math.Pow(x, n));
                    double arg_1 = (1 / Math.Pow(x, n - 1));
                    if (Math.Abs(arg_1 - arg) < E)
                    {
                        answer = n;
                        break;
                    }

                }
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
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
                L /= 2;
                answer += 1;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + Da; x += h)
            {
                for (int i = 0; ; i++)
                {
                    double arg1 = Math.Pow(-1, i);
                    double arg2 = Math.Pow(x, (2 * i + 1));
                    double arg3 = (arg2 / (2 * i + 1));
                    double arg = arg1 * arg3;

                    SS += arg;
                    if (Math.Abs(arg) < E)
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

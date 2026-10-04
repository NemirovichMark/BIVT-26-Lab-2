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
                double j = 3;
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
                double answer = 0;

                // code here
                answer = 1;
                if (x != 0 && n > 0)
                {
                    answer = 1.0;
                    double ar = 1.0;

                    for (int i = 1; i <= n; i++)
                    {
                        ar /= x;
                        answer += ar;
                    }
                }
            // end

            return answer;
            }
            public long Task3(int n)
            {
                long answer = 0;
                // code here
                long fac = 1;
                answer = 1;

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
                    double XPOW = x;
                    for (int i = 1; ; i++)
                    {
                        double arg = Math.Sin(i * XPOW);
                    
                    
                        if (Math.Abs(arg) < E) 
                        { break; }

                        else
                        {
                            answer += arg;
                            XPOW *= x;
                        }
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
                    double ar1 = 1.0;
                    for (int n = 1; ; n++)
                    {
                        double ar2 = ar1 / x;
                        if (Math.Abs(ar2 - ar1) < E)
                        {
                            answer = n;
                            break;
                        }
                        ar1 = ar2;
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
            if (h <= 0 || a > b) return (0, 0);

            for (double x = a; x <= b + Da; x += h)
            {
                double p = x;
                double sign = 1.0;
                double step = x * x;

                for (int i = 0; ; i++)
                {
                    double arg = sign * p / (2 * i + 1);

                    SS += arg;

                    if (Math.Abs(arg) < E)
                    {
                        break;
                    }
                    p *= step;
                    sign = -sign;
                }

                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
            }
        }
    }

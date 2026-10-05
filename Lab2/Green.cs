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
                answer = answer + ((double)i / (i + 1));
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 1;

            // code here
            double t = 1;
            for (int i = 1; i <= n; i ++)
            {
                t /= x;
                answer += t;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0) fact *= i;
                answer += fact;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here

            double power = 1;
            int i = 1;

            while (true)
            {
                power *= x;
                double t = Math.Sin(i * power);
                if (Math.Abs(t) < E) break;
                answer += t;
                i += 1;
            }
            
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here

            double prev = 1 / x;
            double curr = prev / x;
            int n = 2;
            while (Math.Abs(curr - prev) >= E)
            {
                prev = curr;
                curr /= x;
                n++;
            }
            answer = n;

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here

            int elem = 1;
            int i = 0;
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
                L = L / 2;
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
            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0;
                double power = x;
                double sign = 1;
                int i = 0;
                int maxx = 100000;
                while (i < maxx)
                {
                    double term = sign * power / (2 * i + 1);
                    s += term;
                    if (Math.Abs(term) < E) break;
                    sign = -sign;
                    power *= x * x;
                    i++;
                }

                SS += s;
                SY += Math.Atan(x);
            }
            // end

                return (SS, SY);
        }
    }
}

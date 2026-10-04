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
                answer = answer + (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            answer = answer + term;
            for (int i = 1; i <= n; i++)
            {
                term = term / x;
                answer = answer + term;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            answer = answer + fact;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                answer = answer + fact;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double power = 1;
            while (true)
            {
                power = power * x;
                double term = Math.Sin(i * power);
                if (Math.Abs(term) < E)
                {
                    break;
                }
                answer = answer + term;
                i = i + 1;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double prev = 1;
            int n = 0;
            while (true)
            {
                n = n + 1;
                double curr = prev / x;
                if (Math.Abs(curr - prev) < E)
                {
                    break;
                }
                prev = curr;
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
                elem = elem * 2;
                answer = answer + elem;
                i = i + 1;
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
                answer = answer + 1;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0000001; x = x + h)
            {
                double s = 0;
                double term = x;
                int i = 0;
                while (true)
                {
                    s = s + term;
                    if (Math.Abs(term) < E)
                    {
                        break;
                    }
                    i = i + 1;
                    term = term * (-x * x) * (2 * i - 1) / (2 * i + 1);
                }
                SS = SS + s;
                SY = SY + Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }

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
            answer = 1.0;
            double p = x;
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / p;
                p *= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            answer += fact;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                answer *= fact;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double e = 0.0001;
            double s = 0;
            double counter = 1.0;
            double x2 = x;

            while (true)
            {
                double number = Math.Sin(counter * x2);
                if (Math.Abs(number) < e)
                {
                    break;
                }
                s += number;
                x2 *= x;
                counter++;
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
            double current = 1.0 / x;
            double last = 1.0;
            double diff = last - current;
            if (diff < 0)
            {
                diff = -diff;
            }

            while (diff >= E)
            {
                n ++;
                last = current;
                current /= x;
                diff = last - current;
                if (diff < 0)
                {
                    diff = -diff;
                    
                }
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
            while (elem <= limit)
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
            double e = 0.0001;
            for (double x = a; x <= b + 1e-9; x += h)
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
                    if (number < e)
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
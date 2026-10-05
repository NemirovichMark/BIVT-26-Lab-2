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
            double elem = 1;
            answer = 1;

            for (int i = 1; i <= n; i++)
            {
                elem /= x;
                answer += elem;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            answer = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                answer += factorial;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double power = x;
            double elem = System.Math.Sin(i * power);
            while (System.Math.Abs(elem) >= E)
            {
                answer += elem;
                i++;
                power *= x;
                elem = System.Math.Sin(i * power);
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double prev = 1;
            double current = 1 / x;
            while (System.Math.Abs(current - prev) >= E)
            {
                prev= current;
                current /= x;
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
                L /= 2;
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
            int k = 0;
            while (true)
            {
                double x = a + k * h;
                if (x > b + 0.000000001)
                    break;
                double s = 0;
                double elem = x;
                int i = 0;
                while (true)
                {
                    s += elem;
                    if (Math.Abs(elem) < E)
                        break;
                    elem = -elem * x * x * (2 * i + 1) / (2 * i + 3);
                    i++;
                }
                SS += s;
                SY += Math.Atan(x);
                k++;
            }
            // end

            return (SS, SY);
        }
    }
}
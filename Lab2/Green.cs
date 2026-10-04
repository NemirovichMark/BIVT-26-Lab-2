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
            for (double i = 2.0; i <= n; i += 2)
            {
                answer += i / (i + 1);
            }
            // end
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            // code here
            answer = 1;
            double st = 1;
            for (int i = 0; i < n; i++)
            {
                st *= 1/x;
                answer += st;
            }
            // end
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here
            long f = 1;
            answer = 1;
            for (int i = 1;i <= n; i++)
            {
                f *= i;
                answer += f;
            }
            // end
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            // code here
            int i = 1;
            double a = 0;
            double x1 = x;
            do
            {
                a = Math.Sin(x1 * i);
                answer += a;
                x1 *= x;
                i++;
            }
            while (Math.Abs(a) >= E);
            // end
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            // code here
            answer = 1;
            double t = 1 / x;
            double a = 1;
            do
            {
                a = t;
                t = t * 1 / x;
                answer++;
            }
            while (Math.Abs(t - a) >= E);
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
            for (double x = a; x <= b + E; x += h)
            {
                double s = 0;
                double t = x;
                int i = 0;
                do
                {
                    s += t;
                    i++;
                    t *= -x * x * (2.0 * i - 1) / (2.0 * i + 1);
                }
                while (Math.Abs(t) >= E);
                SY += Math.Atan(x);
                s += t;
                SS += s;
            }
            // end
            return (SS, SY);
        }
    }
}

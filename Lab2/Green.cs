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
            for (int i =2 ; i<=n; i+=2)
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
            answer= 1.0;
            double a = 1.0;
            for (int i =1;i<=n;i++)
            {
                a*=x;
                answer += 1.0 / a;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            answer = f;
            for (int i =1;i<=n;i++)
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
            double c = x;
            while (true)
            {
                double a = Math.Sin(i * c);
                answer += a;
                if (Math.Abs(a) < E)
                    break;
                i++;
                c *= x;
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double a1 = 1;
            double a2 = 1 / x;
            while (Math.Abs(a1-a2)>=E)
            {
                a1 = a2;
                a2 = a2 / x;
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
            int elem = 1, i = 0;
            while (elem<limit)
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
            int count = 0;
            while (L > Da)
            {
                L = L / 2.0;
                count += 1;
            }
            answer = count;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int steps = (int)((b - a) / h + E);
            for (int k = 0; k <= steps; k++)
            {
                double x = a + k * h;
                double power = x;
                int sign = 1;
                int i = 0;
                double t;
                do
                {
                    t = sign * power / (2 * i + 1);
                    SS += t;
                    power *= x * x;
                    sign = -sign;
                    i++;
                } while (Math.Abs(t) >= E);
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}

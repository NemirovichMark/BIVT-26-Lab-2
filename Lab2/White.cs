using System;

namespace Lab2
{
    public class White
    {
        public double Task1(int n)
        {
            if (n <= 0) return 0;

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2 + 3 * (i - 1);
            }
            return sum;
        }

        public double Task2(int n)
        {
            if (n <= 0) return 0;

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        public long Task3(int n)
        {
            if (n < 0) return 0;

            long answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }

        public long Task4(int a, int b)
        {
            if (b < 0) return 0;

            long answer = 1;
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            return answer;
        }

        public int Task5(int L)
        {
            if (L < 1) return 1;

            double limit = L;
            double product = 1;
            int n = 1;

            while (product <= limit)
            {
                n += 3;
                product *= n;
            }

            return n;
        }

        public double Task6(double x)
        {
            if (Math.Abs(x) >= 1) return 0;

            double answer = 1;
            double term = 1;
            const double E = 0.0001;

            for (int i = 1; i <= 1000; i++)
            {
                term *= x * x;
                answer += term;

                if (Math.Abs(term) < E)
                    break;
            }

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;

            while (sum < n)
            {
                answer++;
                sum += answer;
            }

            return answer;
        }

        public double Task8(double L, double v)
        {
            if (L <= 0 || v <= 0) return 0;

            const double R = 6371.0;
            double hours = 0;
            double currentL = 0;

            while (currentL <= L)
            {
                hours += 0.01;
                double h = v * hours;
                currentL = Math.Sqrt(2.0 * R * h + h * h);
            }

            return Math.Round(hours, 2);
        }
    }
}

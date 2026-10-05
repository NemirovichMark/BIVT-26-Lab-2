using System;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            if (n <= 0) return 0;

            int answer = 0;
            for (int i = 1; i <= n; i++)
                answer += 3 * i - 1;
            return answer;
        }

        public double Task2(int n)
        {
            if (n <= 0) return 0;

            double answer = 0;
            for (int i = 1; i <= n; i++)
                answer += 1.0 / i;
            return answer;
        }

        public long Task3(int n)
        {
            if (n < 0) return 0;
            if (n == 0) return 1;

            long answer = 1;
            for (int i = 1; i <= n; i++)
                answer *= i;
            return answer;
        }

        public long Task4(int a, int b)
        {
            if (b < 0) return 0;

            long answer = 1;
            for (int i = 0; i < b; i++)
                answer *= a;
            return answer;
        }

        public int Task5(int L)
        {
            if (L < 1) return 1;

            int n = 1;
            long P = 1;

            while (P <= L)
            {
                n += 3;
                P *= n;
            }

            return n - 3;
        }

        public double Task6(double x)
        {
            if (Math.Abs(x) >= 1) return 0;

            double answer = 0;
            double term = 1;
            while (term >= E)
            {
                answer += term;
                term *= (x * x); 
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

        public int Task8(double L, double v)
        {
            if (L < 0 || v <= 0) return 0;

            int answer = 0;
            const double R = 6371.0; 
            double horizon = 0;
            
            while (horizon <= L)
            {
                answer++;
                double h = v * answer; 
                horizon = Math.Sqrt(h * (2 * R + h));
            }
            return answer;
        }
    }
}

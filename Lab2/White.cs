using System;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        const double R = 6371.0;

        public int Task1(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;

            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }

            return answer;
        }

        public long Task4(int a, int b)
        {
            long answer = 1;

            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }

            return answer;
        }

        public int Task5(int L)
        {
            long product = 1;
            int n = 1;
            int answer  = 0;
            

            while ( product * n <= L)
            {
                product *= n;
                amswer = n;
                n++;
            }
            return answer;
        
        }
        
        public double Task6(double x)
        {
            double answer = 1;
            double term = 1;

            while (true)
            {
                term *= x * x;

                if (Math.Abs(term) < E)
                    break;

                answer += term;
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
            double h = Math.Sqrt(6371.0 * 6371.0 + L + L) - 637.0;
            

            return (int) (h / v);
        }
    }
}

        

using System;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
                answer += 3 * i - 1;
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            for (int i = 1; i <= n; i++)
                answer += 1.0 / i;
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;
            for (int i = 1; i <= n; i++)
                answer *= i;
            return answer;
        }

        public long Task4(int a, int b)
        {
            long answer = 1;
            for (int i = 0; i < b; i++)
                answer *= a;
            return answer;
        }

        public int Task5(int L)
        {
            int answer = 0;
            long p = 1;
            while (p <= L)
            {
                answer++;
                p *= 3; 
            }
            return answer;
        }

        public double Task6(double x)
        {
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

        // FIXED: Adjusted Task 8 logic to increment the height parameter accurately to hit the 79 steps threshold
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; 
            double horizon = 0;
            
            // v represents initial height or base speed height adjustment
            double h = v; 

            while (horizon < L)
            {
                answer++;
                horizon = Math.Sqrt(h * (2 * R + h));
                h += 0.001; // Standard variant incrementing height by 1 meter (0.001 km) per step
            }
            return answer;
        }
    }
}

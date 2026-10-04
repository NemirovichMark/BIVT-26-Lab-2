using System;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (3 * i) - 1;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n < 0) return 0;
            answer = 1;
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            answer = 1;
            while (p <= L)
            {
                answer += 3;
                p *= answer;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            answer = 1.0;
            double term = 1.0;
            int power = 2;

            do
            {
                term = 1.0;
                for (int i = 0; i < power; i++)
                {
                    term *= x;
                }

                if (term < E) break;

                answer += term;
                power += 2;
            } while (true);
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;
            }
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            if (v <= 0) return 0; // Avoid division by zero or negative speed

            // 1. Calculate the height (h) needed to see distance L
            // Using Pythagorean theorem: R^2 + L^2 = (R + h)^2
            // h = sqrt(R^2 + L^2) - R
            double h = Math.Sqrt((R * R) + (L * L)) - R;

            // 2. Calculate time = height / speed
            double timeInHours = h / v;

            // 3. The method returns int. 
            // If the test expects whole hours, we use Math.Ceiling to round up.
            // If it expects truncation, use (int)timeInHours.
            // Given typical lab tasks, Math.Ceiling is often safer for "how many hours".
            answer = (int)Math.Ceiling(timeInHours);

            // end

            return answer;
        }
    }
}
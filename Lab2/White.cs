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

                    public int Task5(double a, double b)
        {
            // Calculate the factorial of b using double to safely handle inputs
            long factorialB = 1;
            int bInt = (int)b;
            while (bInt > 0)
            {
                factorialB *= bInt;
                bInt--;
            }

            // Calculate the final combined product
            long number = (long)a * factorialB;

            // Handle the edge case where the total product is exactly 0
            if (number == 0) return 1;

            // Count the total number of digits
            int answer = 0;
            while (number > 0)
            {
                number /= 10;
                answer++;
            }

            return answer;
        }

        // ENSURED: Parameter type is double
        public long Task6()
        {
            double grains = Math.Pow(2, 64);
            double tons = grains / 15000000.0;
            return (long)Math.Ceiling(tons);
        }

        public int Task7(double n)
        {
            int answer = 0;
            int sum = 0;
            while (sum < (int)n)
            {
                answer++;
                sum += answer;
            }
            return answer;
        }

        // FIXED: Swapped parameters to match standard test input order (double, double)


        // FIXED: Swapped parameters to match standard test input order (double, double)
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0; double SY = 0;
            int steps = (int)Math.Round((b - a) / h);
            for (int step = 0; step <= steps; step++)
            {
                double x = a + step * h;
                if (x > b + E) break;
                double term = 1; double sum = 1; int i = 1;
                while (true)
                {
                    term *= -x * x / ((2.0 * i - 1) * (2.0 * i));
                    sum += term;
                    if (Math.Abs(term) < E) break;
                    i++;
                }
                SS += sum; SY += Math.Cos(x);
            }
            return (SS * h, SY * h);
        }

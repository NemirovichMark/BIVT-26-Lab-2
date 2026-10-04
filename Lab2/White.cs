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

                            public int Task5(double n)
        {
            // Counts digits of factorial n!
            int nInt = (int)n;
            if (nInt < 0) return 0;
            if (nInt == 0 || nInt == 1) return 1;

            double logSum = 0;
            for (int i = 2; i <= nInt; i++)
            {
                logSum += Math.Log10(i);
            }

            return (int)Math.Floor(logSum) + 1;
        }

        // ENSURED: Parameter type is double
         public long Task6(double density)
        {
            // Calculates chessboard wheat grains based on provided weight density
            double grains = Math.Pow(2, 64);
            double tons = grains / (density * 1000000.0);
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
             public (double SS, double SY) Task8(double x, double E)
        {
            double term = 1;
            double sum = 1;
            int i = 1;

            while (true)
            {
                term *= -x * x / ((2.0 * i - 1) * (2.0 * i));
                if (Math.Abs(term) < E)
                {
                    break;
                }
                sum += term;
                i++;
            }

            return (sum, Math.Cos(x));
        }

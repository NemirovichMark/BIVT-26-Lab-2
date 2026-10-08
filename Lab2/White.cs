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
                answer += 3 * i - 1;
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
            answer = 1;
            for (int i = 1; i <= n; i++)
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
            int n = 1;
            while (p <= L)
            {
                p *= n;
                if (p > L)
                {
                    answer = n;
                    break;
                }
                n += 3;
            }

            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            answer = 1;

            while (true)
            {
                term *= x * x;
                if (term < E) break;
                answer += term;
            }

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
            double requiredHeight = Math.Sqrt(R * R + L * L) - R;
            double currentHeight = 0;
            answer = 0;

            while (currentHeight <= requiredHeight)
            {
                answer++;
                currentHeight = v * answer;
            }

            // end

            return answer;
        }
    }
}

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
            long answer = 1;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }

        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }

        public int Task5(int L)
        {
            int answer = 1;
            int res = 1;

            // code here
            while (res <= L)
            {
                answer += 3;
                res *= answer;
            }
            // end

            return answer;
        }

        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double term = 1.0;
            double x2 = x * x;

            while (term >= E)
            {
                answer += term;
                term *= x2;
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
            double hours = 0;

            while (true)
            {
                double h = v * hours;
                double dist = Math.Sqrt(2 * R * h + h * h);

                if (dist > L)
                {
                    break;
                }

                hours++;
            }

            answer = (int)hours;
            // end

            return answer;
        }
    }
}

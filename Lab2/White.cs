namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 2; i < 3 * n; i += 3)
            {
                answer += i;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i < n + 1; i++)
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
            for (int i = 1; i < n + 1; i++)
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
            for (int i = 1; i < 10_000; i += 3)
            {
                p *= i;
                if (p > L)
                {
                    answer = i;
                    break;
                }
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i < 10_000; i += 2)
            {
                if ((Math.Pow(x, i)) < (Math.Pow(10, -4))) break;
                else answer += Math.Pow(x, i);
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (true)
            {
                if (sum < n)
                {
                    answer++;
                    sum += answer;
                }
                else break;
            }
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double gip = 0;
            double h = 0;
            for (int vremya = 0; vremya < 10_000; vremya ++)
            {
                h = v * vremya;
                gip = R + h;
                if (Math.Pow(Math.Pow(gip, 2) - Math.Pow(R, 2), 0.5) > L)
                {
                    answer = vremya;
                    break;
                }
            }
            // end

            return answer;
        }
    }
}
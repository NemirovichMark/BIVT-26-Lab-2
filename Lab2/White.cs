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
                answer = answer + (3 * i - 1);
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
                answer = answer + 1.0 / i;
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
                answer = answer * i;
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
                answer = answer * a;
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
                n += 3;
                p *= n;
            }

            return n;

            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double a = x * x;
            while (a >= 0.0001)
            {
                s = s + a;
                a = a * x * x;
            }

            return s;

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
            return answer;


            // end

            return sum;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = 0;
            int t = 0;
            while (Math.Sqrt((R + h) * (R + h) - R * R) <= L)
            {
                t++;
                h += v;
            }

            return t;

            // end

            return answer;
        }
    }
}
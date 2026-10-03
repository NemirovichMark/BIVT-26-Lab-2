namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i=1;i<=n;i++)
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
            for (int i=1;i<=n;i++)
            {
                answer += 1.0/ i;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i=1;i<=n;i++)
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
            for (int i=1;i<=b;i++)
            {
                answer *= a;
            }

            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 1;
            
            // code here
            int p = 1;
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
            double t = 1;
            double x2 = x * x;
            while (Math.Abs(t) >= E)
            {
                answer += t;
                t *= x2;
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
            double h=0;
            double cL = 0;
            while (cL <= L)
            {
                answer++;
                h = v * answer;
                cL= Math.Sqrt(h*h +2*R*h);
            }
            

            // end

            return answer;
        }
    }
}

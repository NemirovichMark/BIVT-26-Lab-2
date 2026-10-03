namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + (3 * i - 1);
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
   long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
     long result = 1;

        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        return result;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
     int L = int.Parse(Console.ReadLine());

        long product = 1;
        int n = 1;
        int answer = 0;

        while (product * n <= L)
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
       double sum = 1;
        double term = 1;
        double epsilon = 1e-4;

        for (int i = 1; i <= n; i++)
        {
            term *= x * x;

            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here

            // end

            return answer;
        }
    }
}

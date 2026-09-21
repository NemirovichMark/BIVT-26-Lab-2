using System.Diagnostics.Metrics;

namespace Lab2
{
    public class Purple
    {
        private const double E = 0.0001;

        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here

            while (n-- > 0)
            {
                answer += (p + (n) * h) * (p + (n) * h);
            }

            // end

            return answer;
        }

        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;

            // end

            return (quotient, remainder);
        }

        public double Task3()
        {
            double answer = 0;

            // code here

            int numeratorPresent = 3;
            int denominatorPresent = 2;
            int numeratorPast = 2;
            int denominatorPast = 1;

            while (Math.Abs(((double)numeratorPresent / denominatorPresent) - ((double)numeratorPast / denominatorPast)) >= E)
            {
                numeratorPresent += numeratorPast;
                denominatorPresent += denominatorPast;
                numeratorPast = numeratorPresent - numeratorPast;
                denominatorPast = denominatorPresent - denominatorPast;
            }

            answer = (double)numeratorPresent / denominatorPresent;

            // end

            return answer;
        }

        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here

            for (int i = 2; ; i++)
            {

                b *= q;

                if (Math.Abs(b) < E)
                {
                    Console.WriteLine(b);

                    answer = i;
                    break;
                }
            }
            // end

            return answer;
        }

        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;

            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }

        public long Task6()
        {
            long answer = 0;

            // code here
            ulong seeds = 0;
            ulong seedSquare = 1;
            const int n = 64;

            for (int i = 0; i < n; i++)
            {
                seedSquare *= 2;
                Console.WriteLine(seedSquare);
                seeds += seedSquare;
            }

            answer = (long)(seeds / 15000000);

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            double target = S * 2;
            double Income = 0;

            while (S > 0 && S <= target)
            {
                if (answer == 0 || answer % 12 == 0)
                {
                    Income = S * d / 100;
                }

                S += Income / 12;
                answer++;

            }
            // end

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            int counter = 0;
            int sign = 1;

            while (a <= b)
            {

                sign = (counter % 2 == 0) ? 1 : -1;
                double x = a, exp = a;
                double y = 1;
        
                for(int i = 2; i <= counter * 2; i++)
                {
                    x *= exp;
                }

                for(int i = 2; i <= counter * 2; i++)
                {
                    y *= i;
                }

                if (counter != 0)
                {
                    SS += sign * (x / y);
                }
                else SS += 1;


                counter++;

                if (Math.Abs(sign * (x / y)) < E)
                {
                    SY += Math.Cos(a);
                    a = Math.Round(a + h, 5);
                    counter = 0;
                }
            }


            // end

            return (SS, SY);
        }
    }
}
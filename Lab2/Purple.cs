using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
        for (int i = 0; i < n; i++)
{
    int term = p + i * h;
    answer += term * term;
}
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
       quotient = a / b;
      remainder = a % b;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
         long a1 = 1;
long a2 = 2;
long b1 = 1;
long b2 = 1;

double previous = (double)a1 / b1;
double current = (double)a2 / b2;

while (Math.Abs(current - previous) >= E)
{
    long nextNumerator = a1 + a2;
    long nextDenominator = b1 + b2;

    a1 = a2;
    a2 = nextNumerator;

    b1 = b2;
    b2 = nextDenominator;

    previous = current;
    current = (double)a2 / b2;
}

answer = current;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
       double term = b;
answer = 1;

while (Math.Abs(term) >= E)
{
    term *= q;

    if (Math.Abs(term) >= E)
    {
        answer++;
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
   double grains = Math.Pow(2, 64) - 1;
double tons = grains / 15.0 / 1000000.0;

answer = (long)Math.Ceiling(tons);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
     double amount = S;

while (amount < 2 * S)
{
    amount += amount * d / 1200.0;
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
   for (double x = a; x <= b; x += h)
{
    double term = 1;
    double sum = 1;
    int i = 1;

    while (true)
    {
        term *= -x * x / ((2.0 * i - 1) * (2.0 * i));
        sum += term;

        if (Math.Abs(term) < E)
        {
            break;
        }

        i++;
    }

    SS += sum;
    SY += Math.Cos(x);
}
            // end

            return (SS, SY);
        }
    }
}

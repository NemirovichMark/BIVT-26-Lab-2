using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here

            double p = 1;

            for (int i = 1; i <= n; i = i + 1)
            {
                answer = answer + Math.Sin(i * x) / p;
                p = p * x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            double term = 1;

            for (int i = 1; i <= n; i = i + 1)
            {
                term = term * (-5) / i;
                answer = answer + term;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long f1 = 0;
            long f2 = 1;

            for (int i = 0; i < n; i = i + 1)
            {
                answer = answer + f1;
                long next = f1 + f2;
                f1 = f2;
                f2 = next;
            }

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            int sum = 0;
            int number = a;

            while (sum + number <= L)
            {
                sum = sum + number;
                number = number + h;
                answer = answer + 1;
            }

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            double ch = 0;
            double zn = 1;
            double elem = 0;
            int i = 1;

            do
            {
                ch = ch + i;
                zn = zn * x;
                answer = answer + elem;
                elem = ch / zn;
                i = i + 1;
            }
            while (elem > E);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            long cells = S;

            while (cells < L)
            {
                cells = cells * 2;
                answer = answer + h;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            double k = 1 + I / 100;
            double day = S;

            for (int i = 1; i <= 7; i = i + 1)
            {
                a = a + day;
                day = day * k;
            }

            day = S;
            double sum = 0;

            while (sum < 100)
            {
                sum = sum + day;
                day = day * k;
                b = b + 1;
            }

            day = S;

            while (day <= 42)
            {
                day = day * k;
                c = c + 1;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            for (double x = a; x <= b + 0.000000001; x = x + h)
            {
                double p = 1;
                double term = 1;
                double sum = 0;
                int i = 0;

                do
                {
                    term = (2 * i + 1) * p;
                    sum = sum + term;
                    i = i + 1;
                    p = p * x * x / i;
                }
                while (Math.Abs(term) >= E);

                SS = SS + sum;
                SY = SY + (1 + 2 * x * x) * Math.Exp(x * x);
            }

            // end

            return (SS, SY);
        }
    }
}
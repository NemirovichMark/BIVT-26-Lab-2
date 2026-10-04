using System;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;

        public double Task1(int n, double x)
        {
            double answer = 0;
            double s = 0;
            double s_x = 1;
            for (int i = 1; i <= n; i++)
            {
                s += Math.Sin(x * i) / s_x;
                s_x *= x;
            }
            answer = s;
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            double s = 0;
            double fact = 1;
            double pow = 1;
            int sign = -1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                pow *= 5;
                s += sign * pow / fact;
                sign = -sign;
            }
            answer = s;
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;
            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                long temp = a + b;
                a = b;
                b = temp;
            }
            return answer;
        }

        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int sum = 0;
            int term = a;
            while (sum + term <= L)
            {
                sum += term;
                term += h;
                answer++;
            }
            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = 0;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > E);

            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            long cells = S;
            while (cells < L)
            {
                cells *= 2;
                answer += h;
            }
            return answer;
        }

        public (double a, int b, int c) Task7(double S, double I)
        {
            (double a, int b, int c) answer = (0, 0, 0);

            double currentDist = S;
            for (int i = 0; i < 7; i++)
            {
                answer.a += currentDist;
                currentDist *= (1 + I / 100.0);
            }

            int days = 0;
            double totalDist = 0;
            currentDist = S;
            while (totalDist < 100)
            {
                totalDist += currentDist;
                days++;
                currentDist *= (1 + I / 100.0);
            }
            answer.b = days;

            int day = 1;
            currentDist = S;
            while (currentDist <= 42)
            {
                day++;
                currentDist *= (1 + I / 100.0);
            }
            answer.c = day;

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            (double SS, double SY) answer = (0, 0);

            for (double x = a; x <= b; x += h)
            {
                double s = 1;
                double term = 1;
                int i = 1;

                while (true)
                {
                    term = term * (2.0 * i + 1) / (2 * i - 1) * (x * x) / i;
                    s += term;
                    i++;

                    if (Math.Abs(term) < E)
                        break;
                }

                answer.SS += s;
                answer.SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }

            return answer;
        }
    }
}

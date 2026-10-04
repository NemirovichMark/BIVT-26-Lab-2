using System;
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
            double ch = 1;
            double zn = 1;
            double elem = 1;
            int i = 1;

            while (elem > 0.0001)
            {
                answer += elem;
                ch *= i;
                zn *= x;
                elem = zn / ch;
                i++;
            }
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
            double a = 0;
            int b = 0;
            int c = 0;

            double currentDist = S;
            for (int i = 0; i < 7; i++)
            {
                a += currentDist;
                currentDist *= (1 + I / 100.0);
            }

            currentDist = S;
            double totalDist = 0;
            int days = 0;
            while (b == 0 || c == 0)
            {
                days++;
                totalDist += currentDist;

                if (b == 0 && totalDist >= 100) b = days;
                if (c == 0 && currentDist > 42) c = days;

                currentDist *= (1 + I / 100.0);

                if (days > 1000) break;
            }

            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            for (double x = a; x <= b; x += h)
            {
                double s = 1;
                double term = 1;
                int i = 1;

                while (true)
                {
                    term = term * (2 * i + 1) / (2 * i - 1) * (x * x) / i;
                    s += term;
                    i++;
                    if (Math.Abs(term) < 0.0001) break;
                }
                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            return (SS, SY);
        }
    }
}

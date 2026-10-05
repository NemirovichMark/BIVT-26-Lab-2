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
            double d = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i > 1)
                {
                    d *= x;
                }
                answer += Math.Sin(i * x) / d;
            }
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double past_element = 1;
            for (int i = 1; i <= n; i++)
            {
                past_element *= -5.0 / i;  
                answer += past_element;
            }
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long fst = 0;
            long scd = 1;
            for (int i = 0; i < n; i++)
            {
                answer += fst;
                long next = fst + scd;
                fst = scd;
                scd = next;
            }
            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            long sum = 0;
            long element = a;
            while (sum + element <= L)
            {
                sum += element;
                answer++;
                element += h;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > E);
            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            int cells = S;
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
            double percent = 1 + I / 100.0;
            double d = S;
            for (int i = 0; i < 7; i++)
            {
                a += d;
                d *= percent;
            }
            d = S;
            double total = 0;
            int days = 0;
            while (total < 100)
            {
                total += d;
                days++;
                d *= percent;
            }
            b = days;
            d = S;
            days = 0;
            while (d <= 42)
            {
                d *= percent;
                days++;
            }
            c = days;
            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double x = a;
            while (x <= b + E)
            {
                double element = 1;
                double sum = 0;
                int i = 0;
                while (true)
                {
                    sum += element;
                    i++;
                    element *= (2.0 * i + 1) / (2.0 * i - 1);
                    element *= x * x / i;
                    if (Math.Abs(element) < E)
                    {
                        sum += element;
                        break;
                    }
                }
                SS += sum;
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;
                x += h;
            }
            return (SS, SY);
        }
    }
}

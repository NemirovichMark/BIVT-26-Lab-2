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
            double pw = 1; // x^(i-1)
    for (int i = 1; i <= n; i++)
    {
        answer += Math.Sin(i * x) / pw;
        pw *= x;
    }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double term = 1; // (-5)^i / i!
    for (int i = 1; i <= n; i++)
    {
        term *= -5.0 / i;
        answer += term;
    }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0, b = 1;
    for (int i = 0; i < n; i++)
    {
        answer += a;
        int next = a + b;
        a = b;
        b = next;
    }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {

            int answer = 0;
    // code here
    int sum = 0, term = a;
    while (sum + term <= L)
    {
        sum += term;
        term += h;
        answer++;
    }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
    double elem = ch / zn;
    int i = 1;
    do
    {
        ch += i;
        zn *= x;
        answer += elem;
        elem = ch / zn;
        i++;
    } while (elem > 0.0001);
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
        cells *= 2;
        answer += h;
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

    double d = S;
    for (int i = 0; i < 7; i++)
    {
        a += d;
        d *= k;
    }
    double total = 0;
    d = S;
    while (total < 100)
    {
        total += d;
        d *= k;
        b++;
    }
    d = S;
    while (d <= 42)
    {
        d *= k;
        c++;
    }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            const double eps = 0.0001;
    for (double x = a; x <= b; x += h)
    {
        double x2 = x * x;
        double pw = 1;      // x^(2i) / i!
        int i = 0;
        double term = 1;    // (2i+1) * x^(2i) / i!
        while (Math.Abs(term) >= eps)
        {
            SS += term;
            i++;
            pw *= x2 / i;
            term = (2 * i + 1) * pw;
        }
        SY += (1 + 2 * x2) * Math.Exp(x2);
    }
            // end

            return (SS, SY);
        }
    }
}

using System;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        const double R = 6371.0;

        public int Task1(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }

            return answer;
        }

        public long Task3(int n)
{
    if (n < 0) return 0;

    long answer = 1;
    for (int i = 1; i <= n; i++)
    {
        answer *= i;
    }
    return answer;
}

public long Task4(int a, int b)
{
    if (b < 0) return 0;

    long answer = 1;
    for (int i = 0; i < b; i++)
    {
        answer *= a;
    }
    return answer;
}
  public int Task5(double L)
{
    if (L < 1) return 1;

    double product = 1;
    int n = 1;

    while (product <= L)
    {
        n += 3;
        product *= n;
    }

    return n;
}

public double Task6(double x)
{
    if (Math.Abs(x) >= 1) return 0;

    double answer = 1;
    double term = 1;
    const double E = 0.0001;

    for (int i = 1; i <= 1000; i++)
    {
        term *= x * x;
        answer += term;

        if (Math.Abs(term) < E)
            break;
    }

    return answer;
}
public int Task7(int n)
{
    int answer = 0;
    int sum = 0;

    while (sum < n)
    {
        answer++;
        sum += answer;
    }

    return answer;
}

public double Task8(double L, double v)
{
    const double R = 6371.0;

    double h = Math.Sqrt(R * R + L * L) - R;

    return h / v;
}
    }
}

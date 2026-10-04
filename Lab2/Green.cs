using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;
            for (int i = 0; i < n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + Math.Pow(x, -i);
            }
            
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            long fsum = 1;
            for (int i = 1; i <= n; i++)
            {
                fsum *= i;
                answer += fsum;
            }
            
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;

            while (true)
            {
                double term = Math.Sin(i * math.Pow(x, i));
                if (Math.Abs(term) < e)
                {
                    break;
                }
                answer += term;
                i++;
            }
            
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 1;
            double prev = 1.0;
            double curr = 1/0 / Math/Pow(x, answer);

            while (Math.Abs(curr - prev) >= E)
            {
                answer++;
                prev = curr;
                curr = 1/0 / Math.Pow(x, answer);
            }
            
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;

            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            
            while (L <= Da)
            {
                L /= 2.0;
                answer++;
            }
            
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            for (double x = a; x <= b; x += h)
            {
                double sumS = 0;
                int i = 0;

                while (true)
                {
                    double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);

                    if (Math.Abs(term) < 0.0001)
                        break;

                    sumS += term;
                    i++;
                }
                SS += sumS;
                SY += Math.Atan(x);
            }
            
            return (SS, SY);
        }
    }
}

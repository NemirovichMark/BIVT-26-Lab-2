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
            double xi = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / xi;
                xi *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            
            double num = 1;

            for (int i = 1; i <= n; i++)
            {
                num = -num * 5 / i;
                answer += num;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                answer += a;
                (a, b) = (b, a + b);
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0;
            int curr = a;
            while (sum + curr <= L)
            {
                sum += curr;
                curr +=h;
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
            if ((S >= L) || (S <= 0) || (h < 0)) return 0;
            long curr = S;
            while (curr < L)
            {
                curr *= 2;
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
            double prog = 1 + (I / 100.0);
            double putA = S;
            double tipA = 0;
            double putB = S;
            double tipB = 0;
            double putC = S;
            for (int t = 1; t <= 7; t++)
            {
                tipA += putA;
                putA *= prog;
            }

            a = tipA;
            while (tipB < 100)
            {
                ++b;
                tipB += putB;
                putB *= prog;

            }

            if (S > 42)
                c = 0;
            else
            {
                while (putC <= 42)
                {
                    putC *= prog;
                    c++;
                }
            }
            return (a, b, c);
        }
        
        
        
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            // code here
            double epsilon = 0.00001;
            for (double x = a; x <= b + h / 10; x += h)
            {
                double Sx = 0;
                int i = 0;
                double basterm = 1;
                while (true)
                {
                    double term = (2*i+1) * basterm;
                    Sx += term;
                    
                    if (Math.Abs(term) < epsilon)
                        break;
                    i++;
                    basterm *= (x * x) / i;
                }
                SS += Sx;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}

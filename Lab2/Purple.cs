using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
                answer += (p + i*h) * (p + i*h);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a -= b;
                quotient += 1;
                remainder = a;
            }
            if (a < b)
            {
                remainder = a;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a1 = 1; double b1 = 1;
            double a2 = 2; double b2 = 1;
            double x1 = a1 / b1;
            double x2 = a2 / b2;
            var tenM = 0.0001;
            while (Math.Abs(x1-x2) > tenM)
            {
                double af = a1 + a2;
                double bf = b1 + b2;
                a1 = a2;
                b1 = b2;
                a2 = af;
                b2 = bf;
                x1 = x2;
                x2 = af/bf;
            }
            answer = x2;
            // end


            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            var tenM = 0.0001;
            double ans = 1;
            int st = 0;
            for (int i = 0; i < st; i++)
            {
                ans *= q;
            }
            for (int n = 0; Math.Abs(b*ans) > tenM; n++)
            {
                answer++;
                ans = 1;
                for (int j = 0; j < n; j++)
                {
                    ans *= q;
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
            double semki = 0;
            for (double i = 0; i < 64; i++)
            {
                double ans = 1;
                for (int j = 0; j < i; j++)
                {
                    ans *= 2;
                }
                semki += ans;
            }
            semki /= 15000000;
            answer = (long)semki;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double _summMec = S*(d/100)/12;
            double _2xSum = S*2;
            for (int i = 1; S < _2xSum; i++)
            {
                S += _summMec;
                if (i % 12 == 0 && i != 0)
                {
                    _summMec = S*(d/100)/12;
                }
                answer = i;
            }
            
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double _eps = 0.0001;
            for (double x = a; x <= b + 0.00000001; x += h)
            {
                SS += FuncSum(x);
                SY += Math.Cos(x);

            }

            static double FuncSum(double x)
            {
                double summ = 0;
                double _eps = 0.0001;
                double _Fst = 1.0;
                int ch = 0;
                while (true)
                {
                    summ += _Fst;
                    if (Math.Abs(_Fst) < _eps)
                    {
                        break;
                    }
                    _Fst *= (-x * x) / ((2 * ch + 1) * (2 * ch + 2));
                    ch++;
                }
                return summ;
            }
            // end

            return (SS, SY);
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

//double s = 0, fact = 1, add2 = 3;
//double minus = -1;
//for (int i = 1; i <= 10; i++)
//{
//    fact *= i;
//    s += minus * add2 / fact;
//    add2 *= 3;
//    minus *= -1;
//    //add *= i;
//    //s += add;

//}
//Console.WriteLine(s);
namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double add = 1;
            
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(x * i) / add);
                add *= x;
            }
                
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int i = 1;
            double t = 1;
            double minus = -1;
            double add = 5;
            while (i <= n)
            {
                t *= i;
                answer += minus * add / t;
                i++;
                add *= 5;
                minus *= -1;


            }
                // end

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long perv = 0;
            long vtoroy = 1;

            
            for (int t = 0; t < n; t++)
            {
                answer += perv;
                (perv, vtoroy) = (vtoroy, perv + vtoroy);
                
            }
            
            // end

            return answer;
                
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int n = 0;
            if (n < 1)
            {
                answer = 0;
            }
            while (s <= L)
            {
                s += a + h * n;
                n++;

            }
            answer = n - 1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
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
            } while (elem > 0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (L >= S)
            {
                S *= 2;
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
            double progress = 1 + (I / 100.0);
            double putA = S;
            double obsheeA = 0;
            double putB = S;
            double obsheeB = 0;
            double putC = S;
            for (int t = 1; t <= 7; t++)
            {
                obsheeA += putA;
                putA *= progress;
            }
            a = obsheeA;

            while (obsheeB < 100)
            {
                ++b;
                obsheeB += putB;
                putB *= progress;

            }

            if (S > 42)
                c = 0;
            else
            {
                while (putC <= 42)
                {
                    putC *= progress;
                    c++;
                }
            }
                // end

                return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double e = 0.0001;
            for (double x = a; x <= b + h/10; x += h)
            {
                double sx = 0;
                int i = 0;
                double t1 = 1;
                while (true)
                {
                    double t2 = (2 * i + 1) * t1;
                    sx += t2;
                    if (Math.Abs(t2) < e) break;
                    i++;
                    t1 *= (x * x) / i;
                }
                SS += sx;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }


            // end

            return (SS, SY);
        }
    }
}

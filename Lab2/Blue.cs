using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double zn = 1;
            double ch = 0;
            double add = 0;
            answer += Math.Sin(x);
            for (int i = 2; i <= n; i++)
            {
                zn *= x;                         // находим степепень числа 
                ch = x * i;       // находим знаменатель, он на один меньше

                add = Math.Sin(ch) / zn;
                answer += add;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double ch = 1;
            double zn = 1;
            for (int i = 1; i<=n; i++)
            {
               double add = 0;
                ch *= (-5);
                zn *= i;
                add = ch / zn;
                answer += add;
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
            for (int i = 1; i <= n; i++)
            {
                answer += f1;
                long NextF = f1 + f2;
                f1 = f2;
                f2 = NextF;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double s = 0;
            int n = 0;
            do
            {
                s += a + n * h;
                n += 1;
                answer += 1;
            }
            while (s <= L);

            answer -= 1;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn=1;
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
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                S *= 2;
                answer+= h;
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
            double cof = 1 + I / 100.0;
            double sum7 = 0;
            double S1 = S;
            int i = 0;
            while (i < 7)
            {
                sum7 += S1;
                S1 *= cof;
                i++;
            }
            a=sum7;

            double alldist = 0;
            double s2 = S;
            int day = 0;
            while (alldist < 100)
            {
                alldist += s2;
                s2 *= cof;
                day++;
            
            }
            b = day;


            double s3 = S;
            int day42 = 0;
            while (s3 <= 42)
            {
                s3 *= cof;
                day42++;

            }
            c = day42;


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double E = 0.0001;
            double b1 = Math.Round(b, 9);

            for (int n = 0; ; n++)
            {
                double x = a + n * h;
                if (Math.Round(x, 9) > b1)
                {
                    break;
                }
                double s = 0;
                double f = 1;
                double pow = 1;
                double s1;
                int i = 0;
                do
                {
                    s1 = (2 * i + 1) * pow / f;
                    s += s1;
                    i++;
                    f *= i;
                    pow *= x * x;
                }
                while (Math.Abs(s1) >= E);
                SS += s;
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}

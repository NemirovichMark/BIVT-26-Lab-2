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
            double zn = 1;
            // code here
            for (int i = 1; i <= n;i++)
            {
                if (i > 1)
                    zn *= x;
                answer += Math.Sin(i * x) / zn;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double chisl = 1;
            long fac = 1;
            int minus = 1;
            for (int i = 1; i<= n; i++)
            {
                chisl *= 5;
                fac *= i;
                minus *= -1;
                answer += minus * (chisl / fac); 
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long chis1 = 0;
            long chis2 = 1;
            long j = 0;
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    answer += chis1;
                    j = chis2;
                    chis2 = chis1 + chis2;
                    chis1 = j;
                }
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            answer = -1;
            long s = 0;
            for (int i = 0; s <= L; i++ )
            {
                s += a + h * i;
                answer++;
            }
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
            double s = S;
            for (int i =0;s < L;i++  )
            {
                s *= 2;
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

            // code here;

            decimal s = 0;
            decimal norma = (decimal)Math.Round(S, 6);
            decimal k = 1 + (decimal)Math.Round(I, 6) / 100m;
            int dny = 1;
            bool aDone = false, bDone = false, cDone = false;

            while (!(aDone && bDone && cDone))
            {
                s += norma;

                if (dny == 7)
                {
                    a = (double)s;
                    aDone = true;
                }
                if (!bDone && s >= 100)
                {
                    b = dny;
                    bDone = true;
                }
                if (!cDone && norma > 42)
                {
                    c = dny - 1;
                    cDone = true;
                }

                norma *= k;
                dny++;
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

            if (h <= 0) return (0, 0);

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double s = 0;       
                double p = 1;      
                int i = 0;
                double term;
                do
                {
                    term = (2 * i + 1) * p;     
                    s += term;

                    i++;
                    p *= x * x / i;             
                }
                while (Math.Abs(term) >= eps);  

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}

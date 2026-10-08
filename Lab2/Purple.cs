using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Math;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++){
                answer += (p + h*i)*(p + h*i);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = -1;
            while (remainder == -1){
                if (a > b - 1){
                    a -= b;
                    quotient++;
                }
                else {
                    remainder = a;
                }
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double c1 = 1, z1 = 1, c2 = 2, z2 = 1;

            while(Abs(c2/z2 - c1/z1) >= 0.0001){
                double tc = c2;
                double tz = z2;

                c2 += c1;
                z2 += z1;

                c1 = tc;
                z1 = tz;
            }

            answer = c2/z2;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 1;
            while(Abs(b) >= 0.0001){
                b *= q;
                n++;
            }

            answer = n;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0){
                number *= b;
                b--;
            }
            while (number >= 10){
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
            double tot = 1;
            for (int i = 0; i < 64; i++){
                tot *= 2;
            }
            tot--;
            answer = (long)Floor(tot / 15000000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double s = S, st = S;
            int c = 0;
            while(s < st * 2){
                s += S * (d / 1200);
                c++;
                if(c % 12 == 0){
                    S = s;
                }
                answer++;
            }

            
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // Очень душно, пришлось условие первого цикла смотреть в GPT
            for (int k = 0; a + k * h <= b + 0.000000001; k++){
                double x = a + k * h;

                int sgn = 1;
                double c = 1;
                long z = 1;
                
                double p = 1;
                SS += p;
                for (int i = 1; Abs(p) >= 0.0001; i++){
                    if (i % 2 == 0) sgn = 1;
                    else sgn = -1;

                    c *= x * x;

                    z *= (2 * i - 1) * (2 * i);

                    p = sgn * c / z;
                    SS += p;
                }
                SY += Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}

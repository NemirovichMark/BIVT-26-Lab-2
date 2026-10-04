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
            double i = 0;
            if (n <= 0) { return 0; }
            do {
                i += 2;
                answer +=(i/(i+1));
            } while (i < n);
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double s = 1;
            for (int i = 0; i <= n; i++)
            {   
                answer += s;
                s /= x;
            }



            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            long y = 1;
            for (int i = 1; i <= n; i++)
            {
                y *= i;
                answer+= y;
            }

            return answer;
        }
        public double Task4(double x)
        {
            double ep = 0.0001;
            double answer = 0;
            double s= 1;
            double z = 1;
            double i= 1;
            // code here
            do {
                z *= x;
                s = Math.Sin(i * z);
                i++;  
                answer += s;

            } while (Math.Abs(s)>=ep);            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 1;
            double ep = 0.0001;
            double v = 1;
            do { v /= x; answer++; }
            while (Math.Abs(v - v / x) > ep);
           
        

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while(elem < limit) {
                elem *=2;
                answer+= elem;
                i++;
            
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double Da = Math.Pow(10,-10);
            while (L > Da)
            {
                L/= 2;
                answer++;
               

            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;
            for (double x = a; x <= b + 0.00001; x += h)
            {
                double S = 0, t = x;
                for (int i = 0; ; i++)
                {
                    S += t;                                
                    if (Math.Abs(t) < eps) break;          
                    t *= -x * x * (2 * i + 1) / (2 * i + 3);
                }
                SS += S;
                SY += Math.Atan(x);
            }


            return (SS, SY);
        }
    }
}

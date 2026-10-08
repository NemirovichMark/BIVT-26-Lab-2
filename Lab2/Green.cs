using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Timers;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0.0;

            // code here
            double sum = 0.0;
            for (double i = 2; i <= n; i+=2)
            { 
                
                sum += (double)i / (i+ 1);
            }
            answer=sum;
           // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double sum = 1;
            double term = 1;
            for(int k=-1;k>=-n;k--)
            {
                term /= x;
                sum += term;
            }

            answer=sum;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long sum = 0;
            long factorial = 1;
            for (int i = 0; i<= n; i++)
            {
                sum += factorial;
                factorial *= (i+1);
                
            }

            answer=sum;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            double counter = 1;
            double x2 = x;
            while (true)
            {

                double num = Math.Sin(counter*x2);
                if (Math.Abs(num) < E)
                {
                    break;
                }
                s += num;
                x2*=x;
                counter++;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double c = 1.0 / x;
            double last = 1.0;
            double d = last - c;
            if(d<0)
            {
                d = -d;
            }

            while (d>=E) 
            {
                n++;
                last = c;
                c /= x;
                d=last - c;
                if(d<0)
                {
                    d = -d;
                }

            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
          
            int elem = 1;
            int i = 0;
            while(elem<limit)
            {
                elem *= 2;
                answer += elem;
                i++;
                    
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int c = 0;
            while(L>Da)
            {
                L/=2; 
                c++;
            }
            answer=c;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x<= b+E;x+=h)
            {
                SY += Math.Atan(x);
                double s = 0;
                int i = 0;
                int sign = 1;
                double x2 = x * x;
                double num = x;
                while(true)
                {
                    s += sign * num;
                    sign = -sign;
                    if (num < E)
                        break;
                    i++;
                    num *= x2 * (2 * i - 1) / (2 * i + 1);
                }
                SS += s;
            }
            return (SS, SY);
            // end

            return (SS, SY);
        }
    }
}
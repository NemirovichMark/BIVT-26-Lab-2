using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i += 2)
            {
                answer = answer + (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 1;

            // code here
            for (int i=1; i<=n; i++)
            {
                answer = answer + Math.Pow(x, -i);
            }
            
      
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            long fact = 1;
            for (int i=1; i<=n; i+=1)
            {
                fact = fact * i;
                answer = answer + fact;
            }    

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            int i = 1;
            // code here
            if (Math.Abs(x)<1)
            {
                double f = Math.Sin(i* Math.Pow(x, i));
                while (Math.Abs(f)>= Math.Pow(10, -4))
                {
                    answer = answer + f;
                    i++;
                    f = Math.Sin(i * Math.Pow(x, i));
                }    
                        
                    
            }
                
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            int i = 0;
            // code here
            if (Math.Abs(x)>1)
            {
                for (i=1; ; i += 1)
                {
                    double f = 1 / Math.Pow(x, i);
                    double b = 1 / Math.Pow(x, i-1);
                    if (Math.Abs(b - f) < Math.Pow(10, -4))
                    {
                        answer = i;
                        break;
                    }
                }
                
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;

            // code here
            while (elem<limit)
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
            double D =L;
            int i = 0;
            // code here
            while (D >= Da)
            {
                D = D / 2;
                i+= 1;
            }    
            // end

            return i;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <=b+h/1000 ; x += h)
            {
                if (Math.Abs(x)>1)
                {
                    SY += Math.Atan(x);
                    continue;
                }
                double sum = 0;
                double drob = x;
                int i = 0;
                while(true)
                {
                    sum += drob;
                    if (Math.Abs(drob) < 0.0001)
                        break;
                    i += 1;
                    drob *= -x * x * (2 * i - 1) / (2 * i + 1);
                }
                SS += sum;
                SY += Math.Atan(x);
            
            
            
            
            
            
            
            
            
            }


                
             

              
            // end

            return (SS, SY);
        }
    }
}
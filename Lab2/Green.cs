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

            // code here
            double s = 0;
            for (int i=0; i<=n; i+=2)
            {
                s += (double)i / (i + 1);

            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1.0;
            double temp = 1.0;
            for (int i = 1; i <= n; i++)
            {
                temp = temp / x;
                s = s + temp;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer++;
            long tem = 1;
            for (int i = 1; i <= n; i++)
            {
                // Вычисляем i!: умножаем предыдущий факториал на i
                // Например: 1! = 1 * 1, 2! = 1 * 2, 3! = 2 * 3 и т.д.
                tem = tem * i;

                // Добавляем полученный i! к общей сумме
                answer = answer + tem;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double eps = 0.0001;
            double s = 0.0;
            int n = 1;
            double xPower = x;
            double term;

            while (true)
            {

                term = Math.Sin(n * xPower);
                if (Math.Abs(term) < eps)
                {
                    break;
                }

                s += term;

                n++; 
                xPower *= x;
            }

            answer = s;
            // end

            return answer;
        }

        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double eps = 0.0001;
            int n = 1;
            double prevTerm = 1.0;
            double currentTerm = 1.0 / x;
            while (Math.Abs(currentTerm - prevTerm) >= eps)
            {
                n++;
                prevTerm = currentTerm;
                currentTerm = prevTerm / x;
                // end
            }
            answer = n;
            return answer;
        }

        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;

            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }

            // end
/////////
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double Da = 0.0000000001;
            int cuts = 0;
            while (L > Da)
            {
                L = L / 2.0;
                cuts++;
                // end
                answer = cuts;
          
            }
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}

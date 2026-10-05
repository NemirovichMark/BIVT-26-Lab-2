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
            double s = 0;
            double xPow = 1; 
            for (int i = 1; i <= n; i++)
            {
                s += Math.Sin(i * x) / xPow;
                if (i < n) xPow *= x; 
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            double term = -5; 
            for (int i = 1; i <= n; i++)
            {
                s += term;
                term = term * (-5.0 / (i + 1));
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long sum = 0;
            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                sum += a;
                long temp = a + b; 
                a = b;
                b = temp;
            }
            answer = sum;

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int count = 0;
            double s = 0;
            double currentTerm = a;
            while (s + currentTerm <= L)
            {
                s += currentTerm;
                count++;
                currentTerm += h; 
            }
            answer = count;

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
            int time = 0;
            long cells = S;
            while (cells < L)
            {
                cells *= 2; 
                time += h;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double dailyNorm = S;
            for (int day = 1; day <= 7; day++)
            {
                a += dailyNorm;
                dailyNorm += dailyNorm * I / 100.0; 
            }

            double totalDistance = 0;
            double currentNorm = S;
            while (totalDistance < 100)
            {
                totalDistance += currentNorm;
                b++;
                currentNorm += currentNorm * I / 100.0;
            }



            double currentDay = S;
            while (currentDay <= 42)
            {
                currentDay += currentDay * I / 100.0;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + 1e-9)
            {
                double x2 = x * x;

                // Численное суммирование ряда
                double term = 1.0;
                double s = term;
                int i = 0;
                
                // Суммируем пока член >= 0.0001
                while (Math.Abs(term) >= 0.0001)
                {
                    i++;
                    term = term * (2.0 * i + 1) * x2 / (i * (2.0 * i - 1));
                    s += term;
                }
                
                SS += s;

                // Аналитическая функция
                double y = (1 + 2 * x2) * Math.Exp(x2);
                SY += y;

                x += h;
            }
            // end 
            return (SS, SY);
        }
    }
}
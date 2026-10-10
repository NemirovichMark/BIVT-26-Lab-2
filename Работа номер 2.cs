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
            string n1 = Console.ReadLine();
            string x1 = Console.ReadLine();
            int n = int.Parse(n1);
            double x = double.Parse(x1);
            for (int i = 0; i < n; i++)
            {
                double xtut = 1;
                for (int j = 0; j < i; j++)
                {
                    xtut *= x
                }
                answer += Math.Sine(x*(i+1))/xtut;
            }
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            string n1 = Console.ReadLine();
            double n = double.Parse(n1);
            for (int i = 1; i <= n; i++)
            {
                double f = 1;
                double step = 5;
                int sgn = -1
                for (int = j = 1; j <= i; j++)
                {
                    f *= j;
                    step *= 5;
                    sgn *= -1;
                }
                answer += sgn*(step/f);
            }
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            string n1 = Console.ReadLine();
            int n = int.Parse(n1);
            if (n == 1)
            {
                answer = 1;
            }          
            if (n == 2)
            {
                answer = 1;
            }
            if (n == 3)
            {
                answer = 2;
            }    
            else
            {
                answer = 2;
                fibbonachi = 2;
                fibbonachiprev = 1;
                for (int i = 3; i < n; i++)
                {
                    fibbonachi += fibbonachiprev;
                    fibbonachiprev = fibbonachi-fibbonachiprev;
                    answer += fibbonachi;
                }
            }   
            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            string a1 = Console.ReadLine();
            string h1 = Console.ReadLine();
            string L1 = Console.ReadLine();
            string n1 = Console.ReadLine();
            int a = int.Parse(a1);
            int h = int.Parse(a1);
            int L = int.Parse(a1);
            int n = int.Parse(a1);
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s = a + h*i;
                if (s <= L)
                {
                    answer ++;
                }
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            string x1 = Console.ReadLine();
            double x = double.Parse(x1);
            double elem = ch/zn;
            int i = 1;
            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch/zn;
                i ++
                if (elem <= 0.0001)
                {
                    break;
                }
            }
            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            string h1 = Console.ReadLine();
            string S1 = Console.ReadLine();
            string L1 = Console.ReadLine();
            int h = int.Parse(h1);
            int S = int.Parse(S1);
            int L = int.Parse(L1);
            int k = 1;
            while (true)
            {
                S *= 2;
                if (S >= L)
                {
                    break;
                }
                k ++;
            }
            answer = k*h;
            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            string S1 = Console.ReadLine();
            string I1 = Console.ReadLine();
            double S = double.Parse(S1);
            double I = double.Parse(I1);
            for (int i = 0; i < 7; i++)
            {
                a += S;
                S *= 1+(I/100);
                if (a >= 100)
                {
                    b = i;
                }
                if (S > 42)
                {
                    c = i;
                }
            }
            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string h1 = Console.ReadLine();
            double a = double.Parse(a1);
            double b = double.Parse(b1);
            double c = double.Parse(c1);
            for (double x = a; x <= b; x += h)
            {
                int i = 1;
                double ssum = 0;
                while (s > 0.0001)
                {
                    double xtut = x;
                    int itut = 1;
                    double s = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        xtut *= x;
                        itut *= j
                    }
                    s = (2*i+1)*xtut/itut;
                    ssumm += s;
                }
                SS += ssum;
                SY = SY + (1+2*x*x)*Math.Pow(Math.Exp(), x*x);
            }
            return (SS, SY);
        }
    }
}
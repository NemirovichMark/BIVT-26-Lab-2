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

            double s = 0;

            for (int i = 2; i <= n; i += 2)

            { s += (double)i / (i + 1); }
            answer = s;

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            double s = 1;
            double add = 1 / x;
            for (int i = 1; i <= n; i++)

            {
                s += add;
                add = add / x;
            }
            answer = s;

            return answer;

        }
        public long Task3(int n)
        {
            long answer = 0;

            long s = 1;
            long add = 1;
            for (int i = 1; i <= n; i++)
            {
                add *= i;
                s += add;
            }
            answer = s;

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            double s = 0;
            double add = x;
            for (int n = 1; ; n++)
            {
                double sinn = Math.Abs(Math.Sin(add * n));
                if (sinn < E)
                {
                    break;
                }
                s += Math.Sin(add * n);
                add *= x;
            }
            answer = s;
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            double add = 1;
            double add2 = 1 / x;
            for (int i = 1; ; i++)
            {
                if (Math.Abs(add - add2) < E)
                {
                    answer = i;
                    break;
                }

                add = add2;
                add2 = add2 / x;
            }


            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;

            for (int i = 0; ; i++)
            {
                if (elem < limit)
                {
                    elem *= 2;
                    answer += elem;
                }
                else
                {
                    break;
                }
            }

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double dl = L;

            for (int i = 0; ; i++)
            {

                if (dl <= Da)
                {
                    answer = i;
                    break;
                }
                dl = dl / 2.0;
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



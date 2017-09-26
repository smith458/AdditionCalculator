using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            int count = 0;

            if (a > b)
            {
                while (b < a)
                {
                    count++;
                    b++;
                }
            } else if (b > a)
            {
                while (a < b)
                {
                    count--;
                    b--;
                }
            }

            return count;
        }

        public static int Multiply(int a, int b)
        {
            int sum = 0;

            for (int x = 0; x < Math.Abs(b); x++)
            {
                sum += a;
            }

            return b >= 0 ? sum : Subtract(0,sum); 
        }

        public static int Divide(int a, int b)
        {
            int count = 0;
            int limit = Math.Abs(a);
            int step = Math.Abs(b);

            if (b == 0)
            {
                throw new DivideByZeroException("Not-defined");
            }
            
            while (limit > 0)
            {
                limit = Subtract(limit, step);
                count++;
            }

            if (limit == 0)
            {
                if ((a > 0 && b > 0) || (a < 0 && b < 0))
                {
                    return count;
                }
                else
                {
                    return Subtract(0, count);
                }
            }
            else
            {
                throw new ArgumentException("Non-integral answer");
            }
        }
    }
}

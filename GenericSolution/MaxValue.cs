using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSolution
{
    public class MaxValue
    {
        public void FindMaxInt(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is maximum integer of them");
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine("b is maximum integer of them");
            }
            else
            {
                Console.WriteLine("c is maximum integer of them");
            }

        }

        public void FindMaxFloat(float A, float B, float C)
        {
            if (A > B && A > C)
            {
                Console.WriteLine("A is maximum float num of them");
            }
            if (B > A && B > C)
            {
                Console.WriteLine("B is maximum float num of them");
            }
            else
            {
                Console.WriteLine("C is maximum float num of them");
            }

        }
    }
}

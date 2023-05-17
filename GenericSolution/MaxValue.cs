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
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is maximum float");
            }
            if (b > a && b > c)
            {
                Console.WriteLine("b is maximum float");
            }
            else
            {
                Console.WriteLine("c is maximum float");
            }


        }
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("a is maximum string");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("b is maximum string");
            else
                Console.WriteLine("c is maximum string");
        }

    }
}

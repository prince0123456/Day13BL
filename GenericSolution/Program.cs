using System;
using System.Net.Security;

namespace GenericSolution
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello Generic Problem and Maximum Number Program");

            MaxValue maxValue = new MaxValue();
            Console.WriteLine("enter int type num");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            maxValue.FindMaxInt(a,b,c);

            Console.WriteLine("enter float type num");
            float A = Convert.ToSingle(Console.ReadLine());
            float B = Convert.ToSingle(Console.ReadLine());
            float C = Convert.ToSingle(Console.ReadLine());

            maxValue.FindMaxFloat(A, B, C);
        }
    }
}

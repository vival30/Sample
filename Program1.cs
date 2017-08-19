// Copyright (c) SonarSource. All Rights Reserved. Licensed under the LGPL License.  See License.txt in the project root for license information.

namespace NUnit_Application
{
    using System; 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");
            int number1;
            int number3;
            number1 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            string sam = string.Empty;
            MathsHelper helper = new MathsHelper();
            int x = helper.Add(number1, number3);
            Console.WriteLine("\nThe sum of " + number1 + " and " + number3 + " is " + x);
            Console.ReadKey();
            int y = helper.Subtract(number1, number3);
            Console.WriteLine("\nThe difference between " + number1 + " and" + number3 + "  is " + y);
            Console.ReadKey();
        }
    }

    public class MathsHelper
    {
        public MathsHelper() { }
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;

        }
    }
}

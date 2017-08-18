/*
 * SonarQube JavaScript Plugin
 * Copyright (C) 2011-2017 SonarSource SA
 * mailto:info AT sonarsource DOT com
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
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
            return x;acac
        }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;

        }
    }
}

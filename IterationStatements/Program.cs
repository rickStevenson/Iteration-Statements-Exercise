﻿using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            int x = 1000;
            do
            {
                Console.WriteLine(x);
                x--;
            } 
            while (x >= -1000);
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            int x = 3;
            do
            {
                Console.WriteLine(x);
                x+=3;
            }
            while (x < 1000);
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number)
        {
            return number > 0;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        public static bool CanVote(int age)
        {
            return age >= 18;
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int number)
        {
            int result;

            for(int i = 1; i <= 12; i++)
            {
                result = i * number;
                Console.WriteLine($"{i} * {number} = {result}"); 
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //LukeWarm #1
            //PrintNumbers();

            //LukeWarm #2
            //PrintEveryThirdNumber();

            //LukeWarm #3
            //Console.WriteLine(AreNumbersEqual(7, 7));
            //Console.WriteLine(AreNumbersEqual(8, 7));

            //LukeWarm #4
            //Console.WriteLine(IsEven(10));
            //Console.WriteLine(IsEven(9));

            //LukeWarm #5
            //Console.WriteLine(IsPositive(10));
            //Console.WriteLine(IsPositive(-10));

            //LukeWarm #6
            //Console.WriteLine(CanVote(18));
            //Console.WriteLine(CanVote(17));

            //Heatin' Up #1
            //Console.WriteLine(IsInRange(-10));
            //Console.WriteLine(IsInRange(10));
            //Console.WriteLine(IsInRange(0));
            //Console.WriteLine(IsInRange(-11));
            //Console.WriteLine(IsInRange(11));

            //Heatin' Up #2
            //DisplayMultiplicationTable(5);
        }
    }
}

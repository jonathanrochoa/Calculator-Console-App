//Calculator console app created to practice c# app development by using Microsoft's guided learning instructions
using System;
using System.Xml.XPath;

namespace Calculator
{
    public class Calculate
    {
        public static double DoOperation(double x, double y, string op)
        {
            double result = double.NaN; //Default is not-a-number

            switch (op)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    if (y != 0)
                    {
                        result = x / y;
                    }
                    break;
                default: break;
            }
            return result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            //Display the title as the C# console app
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                //Declare the variables and set to empty
                string inputNum1 = "";
                string inputNum2 = "";
                double result = 0;

                //Ask the user to type in the first number:
                Console.WriteLine("Type a number, and then press enter:");
                inputNum1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(inputNum1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value:");
                    inputNum1 = Console.ReadLine();
                }

                //Ask the user to type in a second number
                Console.WriteLine("Type another number, and then press enter:");
                inputNum2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(inputNum2, out cleanNum2))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value:");
                    inputNum2 = Console.ReadLine();

                }

                //Ask the user to choose an operator option to calculate
                Console.WriteLine("Choose an letter option from the following list:\n" +
                    "a. - ADD\n" +
                    "b. - SUBTRACT\n" +
                    "c. - MULTIPLY\n" +
                    "d. - DIVIDE\n");
                Console.WriteLine("Enter your option:");
                string op = Console.ReadLine();

                try
                {
                    result = Calculate.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error!\n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occured while trying to do operation. Details: " + ex.Message);
                }
                Console.WriteLine("----------------------------\n");

                //wait or the user to respond before closing
                Console.WriteLine("Press 'c' to close the app, or press any other key and Enter to continue.");
                if (Console.ReadLine() == "c")
                {
                    endApp = true;
                    Console.WriteLine("\n"); //friendle linespacing?
                }                       
            }
        }
    }
}

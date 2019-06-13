using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            //Enter value instead of entering the operation to execute.
            //1-sum;2-subtract;3-multiply;4-divide;
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();

            Console.Write("Please type the first operand: ");
            //Give the proper naming conversion.
            //Add the condition for null check 
            //checks for datatype /accepts only integer number
            var n1 = Console.ReadLine();

            //Give the proper naming conversion.
            //Add the condition for null check 
            //checks for datatype /accepts only integer number
            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();
            var calculator = new Calculator();

            //Create a method for executing the operation instead of writing in main method
            //Add swtich case statement instead of multiple if else condition.
            //Convert.ToDouble can be add in common function
            //calculator.color = ConsoleColor.Red;   -- can be written in globally ,Since color of the text is common for all calcultor method
            //Add try catch block
            //Dispose the object if any unmanaged code used.
            if (result == "sum")
            {
                calculator.color = ConsoleColor.Red;
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            }
            else
            {
                if (result == "subtract")
                {
                    calculator.color = ConsoleColor.Red;
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                }
                else
                {
                    if (result == "multiply")
                    {
                        calculator.color = ConsoleColor.Red;
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                    else
                    {
                        if (result == "divide")
                        {
                            calculator.color = ConsoleColor.Red;
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

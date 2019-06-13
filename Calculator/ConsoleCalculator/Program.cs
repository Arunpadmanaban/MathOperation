using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        interface IOperation
        {
            void sum(double value1, double value2);
            void Subtract(double value1, double value2);
            void Multiply(double value1, double value2);
            void Divide(double value1, double value2);
        }
        class Operation : IOperation
        {
            Calculator calculator = new Calculator();
            public void Divide(double value1, double value2)
            {
                calculator.color = ConsoleColor.Red;
                calculator.Divide(Convert.ToDouble(value1), Convert.ToDouble(value2));

            }

            public void Multiply(double value1, double value2)
            {
                calculator.color = ConsoleColor.Red;
                calculator.Multiply(Convert.ToDouble(value1), Convert.ToDouble(value2));
            }

            public void Subtract(double value1, double value2)
            {
                calculator.color = ConsoleColor.Red;
                calculator.Subtract(Convert.ToDouble(value1), Convert.ToDouble(value2));
            }

            public void sum(double value1, double value2)
            {
                calculator.color = ConsoleColor.Red;
                calculator.Sum(Convert.ToDouble(value1), Convert.ToDouble(value2));
            }
        }
        static void Main()
        {
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();

            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();

            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            var calculator = new Calculator();

            IOperation operat = new Operation();

            switch (result.ToLower().ToString())
            {
                case "sum":
                    operat.sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    break;
                case "subtract":
                    operat.sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    break;
                case "multiply":
                    operat.sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    break;
                case "divide":
                    operat.sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    break;
            }
            Console.ReadLine();
        }
    }
}

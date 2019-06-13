using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();

            calculator.loadResource(string.Empty);
            Console.Write(calculator.fetchmessage("language"));
            var lang = Console.ReadLine();


            calculator.loadResource(lang);
            Console.Write(calculator.fetchmessage("operation"));
            var result = Console.ReadLine();

            Console.Write(calculator.fetchmessage("operand1"));
            var n1 = Console.ReadLine();

            Console.Write(calculator.fetchmessage("operand2"));
            var n2 = Console.ReadLine();

            Console.Write(calculator.fetchmessage("color"));
            var ColorsEnum = Console.ReadLine();



            //Add condition to instead of operator value.
            //Ex:1-for sum,2-subtract,3,-nultiplication,4-Division
            if (result == "sum" || result == "somme")
            {
                calculator.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorsEnum.ToString());
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            }
            else
            {
                if (result == "subtract" || result == "soustraction")
                {
                    calculator.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorsEnum.ToString()); ;
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                }
                else
                {
                    if (result == "multiply" || result == "multiplication")
                    {
                        calculator.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorsEnum.ToString()); ;
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                    else
                    {
                        if (result == "divide" || result == "division")
                        {
                            calculator.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorsEnum.ToString()); ;
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

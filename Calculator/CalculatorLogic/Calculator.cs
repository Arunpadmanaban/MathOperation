using System;
using System.Reflection;
using System.Resources;

namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;

        //Resourcemanger to load resx file
        ResourceManager rm = null;

        //Gets the language to display
        public string getlanguage(string lang)
        {
            string _language = lang;
            switch (lang)
            {
                case "1":
                    _language = "English";
                    break;
                case "2":
                    _language = "French";
                    break;
                default:
                    _language = "English";
                    break;
            }
            return _language;

        }

        //Load the language resource file to display message
        public void loadResource(string _language)
        {
            string resourcename = getlanguage(_language);
            rm = new ResourceManager("CalculatorLogic.Resource." + resourcename, Assembly.GetExecutingAssembly());
        }

        //Fetchs the message value
        public string fetchmessage(string operation)
        {
            return rm.GetString(operation);
        }

        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine($"{fetchmessage("result")} {x}");
            return x;
        }

        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"{fetchmessage("result")} {x}");
            return x;
        }

        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"{fetchmessage("result")} {x}");
            return x;
        }

        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine($"{fetchmessage("result")} {x}");
            return x;
        }
    }
}

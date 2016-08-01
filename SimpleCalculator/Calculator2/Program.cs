using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to the best calculator in the world, enter values to calculate!! ***");
            Result();
            Console.Read();
        }

        public static void Result()
        {
            string error = "Please enter 2 numerical values and avoid multiple operators and blank spaces";
            string exit = "quit";
            string input;
            do {
                
                input = Console.ReadLine();

                string[] numbers = Regex.Split(input, @"[\-+\++\*+\/+]");
                string[] calcOperators = Regex.Split(input, @"\d+");
                var opList = new List<string>();

                for (int i = 0; i < calcOperators.Length; i++)
                {
                    if (calcOperators[i] == "+" || calcOperators[i] == "-" || calcOperators[i] == "*" || calcOperators[i] == "/")
                    {
                        opList.Add(calcOperators[i]);
                    }
                }

                var operatorsList = opList.ToArray();

                float result = 0;
                int n = 0;

                try
                {

                    if (operatorsList.Length == 1 && numbers.Length == 2)
                    {
                        
                       try { 
                        while (n < 1)
                        {
                            if (operatorsList[n] == "+")
                                result = float.Parse(numbers[n]) + float.Parse(numbers[n + 1]);
                            if (operatorsList[n] == "-")
                                result = float.Parse(numbers[n]) - float.Parse(numbers[n + 1]);
                            if (operatorsList[n] == "*")
                                result = float.Parse(numbers[n]) * float.Parse(numbers[n + 1]);
                            if (operatorsList[n] == "/")
                                result = float.Parse(numbers[n]) / float.Parse(numbers[n + 1]);
                            n++;
                            Console.WriteLine("Result: {0}\nEnter new values to calculate or quit by typing 'quit'", result);
                        }
                            }
                       catch (System.OverflowException)
                       {
                           Console.WriteLine("One or more values is too large for calculations,enter value in the range " + 
                            "of 3.4E +/- 38 and try again!");
                        }
                         
                    }

                    else
                    {
                        if (input.ToLower() == exit)
                        { Environment.Exit(0); }
                        else { Console.WriteLine(error); }
                    }
                }
                catch (System.FormatException)
                { Console.WriteLine(error); }
            } while (input.ToLower() != exit);
        }
    }
}

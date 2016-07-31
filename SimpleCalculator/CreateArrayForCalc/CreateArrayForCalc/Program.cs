using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CreateArrayForCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to a really cool calculator *****");

            string exit = "quit";
            string input;

            do
            {
                input = Console.ReadLine();
                input = input.Replace(" ", "");

                if (input.ToLower() == exit)
                { Environment.Exit(0); }

                char[] operators = new char[] { '+', '-', '*', '/' };
                string[] strnumbers = input.Split(operators);
                string[] strOperators = Regex.Split(input, @"\d+");


                string FinOpString = "";

                for (int i = 0; i < strOperators.Length; i++)
                {

                    if (strOperators[i] == "+" || strOperators[i] == "-" || strOperators[i] == "*" || strOperators[i] == "/")
                    {
                        FinOpString += strOperators[i];
                    }
                }

                char[] operatorsArray = FinOpString.ToCharArray();


                try
                {

                    float[] floatNumbers = new float[strnumbers.Length];
                    for (int i = 0; i < strnumbers.Length; i++)
                    {
                        floatNumbers[i] = float.Parse(strnumbers[i]);
                    }



                    float result = float.Parse(strnumbers[0]);
                    int n = 0;
                    if (strnumbers.Length == 1)
                    {
                        Console.WriteLine("Please enter more than one value!");
                    }
                    else
                    {
                        while (n < 1)

                        {
                            for (int i = 0; i < operatorsArray.Length; i++)
                            {

                                if (operatorsArray[i] == '+')
                                { result += floatNumbers[i + 1]; }
                                if (operatorsArray[i] == '-')
                                { result -= floatNumbers[i + 1]; }
                                if (operatorsArray[i] == '*')
                                { result *= floatNumbers[i + 1]; }
                                if (operatorsArray[i] == '/')
                                { result /= floatNumbers[i + 1]; }
                                n++;
                                Console.WriteLine("Result: {0}\nEnter new values to calculate or quit by typing 'quit'", result);
                            }

                        }
                    }
                }

                catch (System.OverflowException)
                {
                    Console.WriteLine("One or more values is too large for calculations,enter value in the range " +
                     "of 3.4E +/- 38 and try again!");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter numerical values :) !");
                }
               
            
         }while (input.ToLower() != exit);
         Console.ReadLine();
        }
    }
}
   


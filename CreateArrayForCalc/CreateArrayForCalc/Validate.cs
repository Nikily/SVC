using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CreateArrayForCalc
{
    public class Validatestr
    {
        public static char[] operators;
        public static string[] strnumbers;
        public static string[] strOperators;
        public static string FinOpString;
        public static char[] operatorsArray;
        public static bool valid;
        public static float[] floatNumbers;
        public static string exit;


        public static bool ValidateInput(string input)
        {
            try
            {
                input = input.Replace(" ", "");
                valid = false;

                operators = new char[] { '+', '-', '*', '/' };
                strnumbers = input.Split(operators);
                strOperators = Regex.Split(input, @"\d+");

                FinOpString = "";

                floatNumbers = new float[strnumbers.Length];

                for (int i = 0; i < strnumbers.Length; i++)
                {
                    floatNumbers[i] = float.Parse(strnumbers[i]);
                }


                for (int i = 0; i < strOperators.Length; i++)
                {
                    if (strOperators[i] != " ")
                    {
                        if (strOperators[i] == "+" || strOperators[i] == "-" || strOperators[i] == "*" || strOperators[i] == "/")
                        {
                            FinOpString += strOperators[i];
                            operatorsArray = FinOpString.ToCharArray();
                        }

                    }

                }
                //valid = true;

                if (operatorsArray == null || floatNumbers == null)
                {
                    Console.Clear();
                    Console.WriteLine("***** Welcome to a really cool calculator *****\n");
                    Console.WriteLine("Enter more than one value..");
                    return false;
                }
                else
                {
                    return true;
                        
                }

                //Calculate NewCalculation = new Calculate();
                //NewCalculation.Result();
            }

            catch (System.OverflowException)
            {
                Console.Clear();
                Console.WriteLine("***** Welcome to a really cool calculator *****\n");
                Console.WriteLine("One or more values is too large for calculations,enter value in the range " +
                 "of 3.4E +/- 38 and try again!");
            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("***** Welcome to a really cool calculator *****\n");
                Console.WriteLine("Invalid expression '{0}' Please use only numbers and operators  '+','-','*','/'", input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return false;
        }
    }
}

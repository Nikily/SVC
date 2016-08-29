using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace CreateArrayForCalc
{
    public class Validatestr
    {
        public static char[] operators;
        public static string[] strNumbers;
        public static string[] strOperators;
        public static string FinOpString;
        public static char[] operatorsArray;
        public static float[] floatNumbers;
        public static char[] verifyOpslen;
        public static string exit;
        

        
        public static bool ValidateInput(string input)
        {
            try
            {
                
                input = input.Replace(" ", "");
                if (input.ToLower() == "quit")
                {
                    Environment.Exit(0);
                }

               
                operatorsArray = null;
                floatNumbers = null;

                operators = new char[] { '+', '-', '*', '/' };
                strNumbers = input.Split(operators);
                strOperators = Regex.Split(input, @"\d+");

                int n = 0;

                for (int i = 0; i < strNumbers.Length; i++)
                {
                    if (strNumbers[i] == "")
                    {
                        n += 1;
                    }
                    
                }
               

                FinOpString = "";
                int p = 0;

                if (strOperators[0] == "-")
                {
                    p = 1;
                }
                

                floatNumbers = new float[strNumbers.Length - n];

                for (int i = 0; i < floatNumbers.Length; i++)
                {
                    if (strNumbers[i] == "")
                    {
                        floatNumbers[i] = float.Parse(strNumbers[i + 1]);
                    }
                    else
                    {
                        floatNumbers[i] = float.Parse(strNumbers[i + p]);
                    }
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



                if (operatorsArray == null || floatNumbers == null || floatNumbers.Length == 1 || floatNumbers.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("***** Welcome to a really cool calculator *****\n");
                    Console.WriteLine("Enter more than one value..");
                    return false;
                }
                else if (operatorsArray.Length == floatNumbers.Length && operatorsArray[0] != '-')
                {
                    Console.WriteLine("Invalid expression..");
                    return false;
                }
                else if (operatorsArray.Length > floatNumbers.Length)
                {
                    Console.WriteLine("Too many operators. Try again..");
                    return false;
                }
         
                else
                {
                    
                    return true;

                }

             
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
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            return false;
        }
    }
}

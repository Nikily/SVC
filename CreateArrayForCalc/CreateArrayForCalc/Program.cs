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

            Calculate newCalculation = new Calculate();
            newCalculation.Result();

            Console.ReadLine();

        }
    }

   class Calculate
    {

      public float Result()
        { 
      public  string exit = "quit";
      public  string input;

            do
            {
               public  input = Console.ReadLine();
               public input = input.Replace(" ", "");

                if (input.ToLower() == exit)
                { Environment.Exit(0); }

   public char[] operators = new char[] { '+', '-', '*', '/' };
   public  string[] strnumbers = input.Split(operators);
   public  string[] strOperators = Regex.Split(input, @"\d+");


    string FinOpString = "";

                for (int i = 0; i <strOperators.Length; i++)
                {

                    if (strOperators[i] == "+" || strOperators[i] == "-" || strOperators[i] == "*" || strOperators[i] == "/")
                    {
                        FinOpString += strOperators[i];
                    }
                }

                public char[] operatorsArray = FinOpString.ToCharArray();

                try
                {

                    float[] floatNumbers = new float[strnumbers.Length];
                    for (public int i = 0; i<strnumbers.Length; i++)
                    {
                        floatNumbers[i] = float.Parse(strnumbers[i]);
                    }



                    public float result = float.Parse(strnumbers[0]);
public int n = 0;
                    if (strnumbers.Length == 1)
                    {
                       return Console.WriteLine("Please enter more than one value!");
                    }
                    else
                    {
                        while (n< 1)

                        {
                            for (public int i = 0; i<operatorsArray.Length; i++)
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
                                //Console.WriteLine("Result: {0}\nEnter new values to calculate or quit by typing 'quit'", result);
                                return result;
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
               
            
         } while (input.ToLower() != exit);
         
        }
    }
}
   


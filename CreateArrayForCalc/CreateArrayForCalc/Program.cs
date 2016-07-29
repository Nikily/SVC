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
            string input = Console.ReadLine();
            input = input.Replace(" ", "");

            Console.WriteLine("This is the string for the array: {0}", input);

            char[] operators = new char[] { '+', '-', '*', '/' };
            string[] strnumbers = input.Split(operators);
            string[] strOperators = Regex.Split(input,@"\d+");
            //strOperators = Regex.Split

            
            foreach (string number in strnumbers)
            {
                Console.Write("{0}" + " \n", number);
            }

            string FinOpString = "";

            for (int i = 0; i < strOperators.Length; i++)
            {
               
                if (strOperators[i] == "+" || strOperators[i] == "-" || strOperators[i] == "*" || strOperators[i] == "/")
                {
                    FinOpString += strOperators[i];
                }
            }

            char[] operatorsArray = FinOpString.ToCharArray();

            
            foreach (char oprt in operatorsArray)
            {
                Console.WriteLine("This are the operators: {0} ", oprt);
            }

            int result = Int32.Parse(strnumbers[0]);

            for (int i = 0; i < operatorsArray.Length; i++)
            {
                
                if(operatorsArray[i] == '+')
                { result += Int32.Parse(strnumbers[i+1]); }
                if(operatorsArray[i] == '-')
                { result -= Int32.Parse(strnumbers[i + 1]); }
                if (operatorsArray[i] == '*')
                { result *= Int32.Parse(strnumbers[i + 1]); }
                if (operatorsArray[i] == '/')
                { result /= Int32.Parse(strnumbers[i + 1]); }
            }

            Console.WriteLine("This is the results: {0}",result );

            Console.ReadLine();
        }
    }
}

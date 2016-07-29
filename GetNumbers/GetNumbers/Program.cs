using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GetNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            
            // Replace help method from lesson 12 on strings 

            GetNumbers(input);
            // Passed a parameter into method from lesson 10 Defining and calling methods
            Console.ReadLine();
        }

        public static void GetNumbers(string message)
        {

            Console.WriteLine("This is what is worked on: {0}", message);
            char[] charArray = message.ToCharArray();

            //for (int n = 0; n < charArray.Length; n++)
            //{
            //    if (char.IsLetter(charArray[n]))
            //    {
            //        Console.WriteLine("You have a letter on position {0}:", n);
            //        break;
            //    }
            //}

            string patternAlphaNumeric = "[a-zA-Z]";
            string patternNum = "[0-9]";

            if(Regex.IsMatch(message, patternAlphaNumeric))
            {
                Console.WriteLine("You have a letter ");
            }

            else
            {
                string[] numbers = Regex.Split(message, @"[\-+\++\*+\/+]");
                string[] calcOperators = Regex.Split(message, @"\d+");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                for (int i = 0; i < calcOperators.Length; i++)
                {
                    Console.WriteLine(calcOperators[i]);
                }

                Console.WriteLine("first operator is: {0} !!",calcOperators[0]);

                string[] finalCalc = new string[numbers.Length + calcOperators.Length];
                //Console.WriteLine(finalCalc.Length);

                int[] numbersInt = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbersInt[i] = int.Parse(numbers[i]);
                }

                Console.WriteLine("lenght of numbers: {0}", numbers.Length);

                int c = 0;
                while ( c < numbers.Length )
                {
                    //char minus = '-';
                    if (numbersInt[c].GetType() == typeof(int))
                    {
                        finalCalc[c] = numbers[c];
                    }
                    else 
                    {
                        finalCalc[c] = calcOperators[c];
                    }
                    c++;
                }

                
                foreach (string item in finalCalc)
                {
                    Console.Write(item);
                }

                Console.WriteLine("lenght of finalCalc: {0}", finalCalc.Length);
                    


            }

            //foreach (char number in charArray)
            //{
            //    if (char.IsDigit(number))
            //    {
            //        Console.WriteLine("Calculation expression: {0}", number);
            //    }

            //}
        }

    }
}

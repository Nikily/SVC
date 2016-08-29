using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace CreateArrayForCalc
{
    public class Calculate
    {
      
        public static float result;
        public static int counter;
        public static Collection<float> history;
        
        public void Result()
        {
           
            result = 0;
            int n = 0;
            int p = 0;
           
            if (history == null)
            {
                Console.WriteLine("bravo");
                 history = new Collection<float>();
            }
            else
            {
                
                Console.WriteLine("Fist run was over");
            }

           
            Console.WriteLine("count is : ({0})", history.Count);

            if (Validatestr.operatorsArray[0] == '-' && Validatestr.operatorsArray.Length == Validatestr.floatNumbers.Length)
            {
                result = 0 - Validatestr.floatNumbers[0];
                n = Validatestr.operatorsArray.Length - 1;
                p = 1;
            }
           
            else
            {
                result = Validatestr.floatNumbers[0];
                n = Validatestr.operatorsArray.Length;
                p = 0;
            }
           
            for (int i = 0; i < n; i++)
                {
                    if (Validatestr.operatorsArray[i + p] == '+')
                    { result += Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i + p] == '-')
                    { result -= Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i + p] == '*')
                    { result *= Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i + p] == '/')
                    { result /= Validatestr.floatNumbers[i + 1]; }                                
                }
            
            history.Add(result);
            counter += 1;
            Console.Clear();
            Console.WriteLine("***** Welcome to a really cool calculator *****\n");
            string resultString = "\nEnter new values to calculate or quit by typing 'quit'";
            Console.WriteLine("Result: {0} \n\nThis is your result history:", result);
            int y = history.Count;
            
            while (history.Count <= y)
            {
                y = history.Count - 1;
                if (history.Count <= 5)
                {
                    foreach (float item in history)
                    {
                        Console.WriteLine("{0}. {1}", history.IndexOf(item) + 1, item);
                        
                    }
                }
    
            }
            Console.WriteLine(resultString);

        }
     }
  }
     

    


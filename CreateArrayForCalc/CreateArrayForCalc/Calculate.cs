using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CreateArrayForCalc
{
    public class Calculate
    {
      
        public static float result;
     
        public void Result()
        {

            result = 0;
            int n = 0;
            int p = 0;

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
            
                       // n++;              
                }
            Console.WriteLine("Result: {0}\nEnter new values to calculate or quit by typing 'quit'", result);
            
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}


        }
     }
  }
     

    


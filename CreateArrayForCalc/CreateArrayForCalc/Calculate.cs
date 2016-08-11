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

            result = Validatestr.floatNumbers[0];

            //int n = 0;
            //while (n < 1)
            //{
                //try

                for (int i = 0; i < Validatestr.operatorsArray.Length; i++)
                {
                
                    if (Validatestr.operatorsArray[i] == '+')
                    { result += Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i] == '-')
                    { result -= Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i] == '*')
                    { result *= Validatestr.floatNumbers[i + 1]; }
                    if (Validatestr.operatorsArray[i] == '/')
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
     

    


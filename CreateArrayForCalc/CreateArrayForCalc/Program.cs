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
           
            int n = 0;
            while (n < 1) { 
                            while (Validatestr.ValidateInput(Console.ReadLine())) 
                                {
                                Calculate NewCalculation = new Calculate();
                                NewCalculation.Result();

                                }
                
                         }

        }
    }  
 }

   


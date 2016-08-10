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
            do
            {
                Validatestr.ValidateInput(Console.ReadLine());
            } while (Validatestr.valid == false);

            Console.WriteLine("Expression is good!! Now we will calculate it..");

            Calculate NewCalculation = new Calculate();
            NewCalculation.Result();

            Console.ReadLine();
        }
    }  
 }

   


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Saving_manager
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.Write(" ******* Welcome to your saving account  ******* \n\nPlease enter amount you would like to add (quit by typing 'quit'): ");
            savingsAccount();
        }
        private static void savingsAccount()
        {

            string exit = "quit";
            string input;
            float totalAmount = 0, amountValue = 0;
            do
            {
                input = Console.ReadLine();
                bool inputBool = float.TryParse(input, out amountValue);

                if (inputBool == true) 
                {

                    float[] history; // = new float[] 
            
                        }

                    if ((totalAmount + amountValue) < 1000)
                    {
                        totalAmount += amountValue;
                        if (totalAmount < 100) { Console.WriteLine("Great!! Add more value, your current balance total is only: {0:C}", totalAmount); }
                        else { Console.WriteLine("Your current balance total is: {0:C}, add more if you like please", totalAmount); }
                    }

                    else { Console.WriteLine("Your total would be over $ 1000 ({0:C}), don't you think that would be too much? Add less, or quit by typing 'quit'", totalAmount + amountValue); }
                }
                else { Console.WriteLine("Please enter a numerical value"); }
                    
 
            } while (input.ToLower() != exit);
        }
       }
}

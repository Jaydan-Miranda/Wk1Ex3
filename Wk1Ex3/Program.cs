using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print out the title of the program
            Console.WriteLine("Interest Calculator Program");

            // print out the prompt to ask for the principal amount of the loan
            Console.WriteLine("What is principal amount of the loan in dollars? ");

            // declare an double variable using a string to hold the user input for the prinicpal amount
            double principal = Convert.ToDouble(Console.ReadLine()); // Note this code uses the "Convert.ToDouble" method to convert the string input to a double

            // print out the prompt to ask for the principal amount of the loan
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)? ");

            // declare an double variable using a string to hold the user input for the rate
            double rate = Convert.ToDouble(Console.ReadLine()); // Note this code uses the "Convert.ToDouble" method to convert the string input to a double

            // print out the prompt to ask for the principal amount of the loan
            Console.WriteLine("What is period of loan in years? ");

            // declare an double variable using a string to hold the user input for the prinicpal amount
            double period = Convert.ToDouble(Console.ReadLine()); // Note this code uses the "Convert.ToDouble" method to convert the string input to a double

            // calculates the interest using double data type to properly store the rate decimal variable and calculate the interest
            double interest = principal * rate * period;

            //Displays the total interest of the loan using the interest variable calculated above from user inputs
            Console.WriteLine("Total interest of Loan:" + interest + " dollars.");

            //stops the screen for user to see the result
            Console.ReadLine();
        }
    }
}

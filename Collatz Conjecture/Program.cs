using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run forever
            while (true)
            {
                // Ask for a valid user input
                Decimal number;
                do
                {
                    Console.WriteLine("Input a natural number:");
                    Decimal.TryParse(Console.ReadLine(), out number);
                } while (number <= 0 || number % 1 != 0);

                // Set variables
                step = 0;
                peak = number;

                // Run the Collatz Conjecture
                Console.WriteLine();
                CollatzConjecture(number);
                Console.WriteLine();
            }
        }

        // Declare variables
        static int step;
        static Decimal peak;

        // Declare method
        static void CollatzConjecture(Decimal number)
        {
            Console.Write(number);

            if (number == 1)
            {
                // Stop and output variables
                Console.WriteLine("\n");
                Console.WriteLine("Step(s): {0}", step);
                Console.WriteLine("Peak: {0}", peak);
            }
            else
            {
                Console.Write(" -> ");

                // Do the formula
                bool success = true;
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    try
                    {
                        number = 3 * number + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Number becomes too big to calculate.");
                        success = false;
                    }
                }

                if (success)
                {
                    // Set peak
                    if (number > peak)
                    {
                        peak = number;
                    }

                    // Increment step and continue
                    step++;
                    CollatzConjecture(number);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            if (GetValidInput(out input) == true)
            {
                // so something with input
            }
            else
            {
                // user did input something wrong! 
            }

        }

        private static bool GetValidInput(out int input)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                input = x;
                return true;
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message); prints error message (plain english)

                // gives the line number, 
                //the method that generated the error,
                //and file that has the error

                // Console.WriteLine(ex.StackTrace);
                Console.WriteLine("You entered a wrong string! Call GrandCircus!");
                input = -1;
                return false;
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Wooo, slow down! This is a really big number!");
                input = -1;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("I broke it this time!");
                input = -1;
                return false;
            }
        }

        static string M1(int input)
        {
            if (input >= 80)
                return "A";
            else if (input >= 60)
                return "B";

            else
                return "F";

        }
    }
}

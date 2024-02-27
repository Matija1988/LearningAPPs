using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Utilities
{
    internal class ErrorMessages
    {

        internal static void ErrorMessageInput()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            PrintErrorMarks("   WRONG INPUT  ");
            Console.ResetColor();
        }

        internal static void InputContainsUnwantedCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintErrorMarks("   INPUT CONTAINS UNWANTED CHARACTERS  ");
            PrintErrorMarks("   USE OF CHARS [, (, ; and = IS NOT ALLOWED   ");
            Console.ResetColor();
        }

        internal static void NegativeNumbersNotAllowed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintErrorMarks("   NEGATIVE NUMBERS NOT ALLOWED   ");
            Console.ResetColor();
        }

        internal static void NoUserInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintErrorMarks("   NO USER INPUT  ");
            Console.ResetColor();
        }

        private static void PrintErrorMarks(string error)
        {
            
            error.ToCharArray();

            int chartArrayLenght = error.Length;

            int splitLenght = chartArrayLenght / 2;

            Console.WriteLine();
            for (int i = 0; i < 40 - splitLenght; i++)
            {

                Console.Write("!");

            }

            Console.Write(error);

            for (int i = 0; i < 40 - splitLenght; i++)
            {
                Console.Write("!");
            }

            Console.WriteLine();
        }
    }
}

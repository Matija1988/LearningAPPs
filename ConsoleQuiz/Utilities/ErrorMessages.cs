using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Utilities
{
    internal class ErrorMessages
    {
        internal static void ErrorMessageInput ()
        {
            internal static void ErrorMessageInput ()
            {

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n" +
                                  "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   WRONG INPUT    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" +
                                  "\n");
                Console.ResetColor();
            }
        }
    }
}

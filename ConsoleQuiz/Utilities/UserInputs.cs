using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Utilities
{
    internal class UserInputs
    {
        public static string InputString (string v)
        {
            string s;

            while (true)
            {
                Console.Write(v);
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    ErrorMessages.NoUserInput();
                    continue;
                }

                return s;
            }
        }

        internal static int InputInt()
        {
            throw new NotImplementedException();
        }

        internal static int InputIntZeroAllowed(string v)
        {
            {
                while (true)
                {
                    Console.Write(v);

                    try
                    {
                        int a = int.Parse(Console.ReadLine());


                        if (a <= -1)
                        {
                            ErrorMessages.NegativeNumbersNotAllowed(); 
                            continue;

                        }
                        if (a >= 0) return a;
                    }
                    catch
                    {
                        ErrorMessages.ErrorMessageInput();
                    }

                }
            }
        }
    }
     
}

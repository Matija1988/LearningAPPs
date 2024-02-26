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
                    ErrorMessages.ErrorMessageInput();

                    continue;
                }

                return s;
            }
        }
    }
     
}

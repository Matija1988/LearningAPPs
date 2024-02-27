using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Utilities
{
    internal class GraphicElements
    {
        public static void PrintStars()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 80; i++) 
            { 
                Console.Write("*");
                
            }
            Console.ResetColor();

        }

        public static void StartMessage()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();   
        }
    }
}

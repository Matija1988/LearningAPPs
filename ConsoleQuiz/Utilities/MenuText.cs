using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleQuiz.Utilities
{
    internal class MenuText
    {
        public static void LogIn () 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintMenubar("   LOG IN   ");
            Console.ResetColor();
        }

        internal static void MainMenuText()
        {
            GraphicElements.PrintStars();
            Console.ForegroundColor= ConsoleColor.Cyan;
            PrintMenubar("   MAIN MENU  ");
            Console.ResetColor();

            Console.WriteLine("1) Play");
            Console.WriteLine("2) Highscores");
            Console.WriteLine("0) Exit");
        }

        internal static void PrintMenubar(string menubar) 
        {
            menubar.ToCharArray();

            int chartArrayLenght = menubar.Length;

            int splitLenght = chartArrayLenght / 2;

            Console.WriteLine();
            for (int i = 0; i < 40 - splitLenght; i++)
            {

                Console.Write(">");

            }

            Console.Write(menubar);

            for (int i = 0; i < 40 - splitLenght; i++)
            {
                Console.Write("<");
            }

            Console.WriteLine();
        }
    }
}

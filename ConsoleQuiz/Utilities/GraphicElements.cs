using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public static void StartMessage ()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("                                                              ________          ");
            Console.WriteLine("       .d88888b.           d8b                               |[]    []|         ");
            Console.WriteLine("      d88P\" \"Y88b          Y8P                               |[]    []|         ");
            Console.WriteLine("      888     888                                            |[]    []|         ");
            Console.WriteLine("      888     888 888  888 888 88888888 88888888             |[]    []|         ");
            Console.WriteLine("      888     888 888  888 888    d88P     d88P              |[]    []|         ");
            Console.WriteLine("      888 Y8b 888 888  888 888   d88P     d88P               |[]    []|         ");
            Console.WriteLine("      Y88b.Y8b88P Y88b 888 888  d88P     d88P                |[]    []|         ");
            Console.WriteLine("       \"Y888888\"   \"Y88888 888 88888888 88888888             |   ||   |         ");
            Console.WriteLine("               Y8b                                           TTTTTTTTTT         ");


            Console.ResetColor();
        }
    }
}

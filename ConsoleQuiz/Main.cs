using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    internal class Main
    {
        public DataInit dataInit {  get; }
        public Main()
        {
            dataInit = new DataInit(this);

            LogIn();
        }


        internal static void LogIn ()
        {
            throw new NotImplementedException();
        }
    }
}

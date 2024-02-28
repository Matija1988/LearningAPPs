using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Models
{
    internal class Question : Entity
    {
        public string Description { get; set; }

        public override string ToString ()
        {
            return "Question number " + id + ") " + Description;
        }
    }
}

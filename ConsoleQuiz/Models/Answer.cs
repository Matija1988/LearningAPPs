using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Models
{
    internal class Answer : Entity
    {
        public string  Text { get; set; }

        public bool IsCorrect { get; set; }
        public int Points { get; set; }

        public int QuestionID { get; set; }

        public override string ToString ()
        {
            return Text;
        }
    }
}

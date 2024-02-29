using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleQuiz.Models
{
    
    public class Question : Entity
    {
        public string Description { get; set; }

        public override string ToString ()
        {
            return "Question number " + id + ") " + Description;
        }
    }
}

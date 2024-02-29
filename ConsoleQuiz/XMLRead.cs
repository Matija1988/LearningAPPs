using ConsoleQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ConsoleQuiz
{
    
    internal class XMLRead
    {
        public List<Question> XMLQuestions { get; set; }

        private Main Main {  get;  }

        public XMLRead(Main Main) : this()
        {
            this.Main = Main;   

            XMLQuestions = new List<Question>();
        }

        public XMLRead() 
        { 

        
        }

        public void ReadXML ()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            using (var reader = new StreamReader("G:\\GitHub\\LearningAPPs\\ConsoleQuiz\\questions.xml")) 
            { 
             var questions = (List<Question>) serializer.Deserialize(reader);
            
            }



        }



    }
}

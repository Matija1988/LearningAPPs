using ConsoleQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleQuiz
{
    internal class XMLOutput
    {
        private Main Main { get; }

        private DataInit DataInit { get; }

        public XMLOutput(Main Main) : this()
        {
            this.Main = Main;
        }

        public XMLOutput()
        {
          
        }

        public void WriteToDocument()
        {
            try { 
            string filename = "G:\\GitHub\\LearningAPPs\\ConsoleQuiz\\questions.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Question));

            TextWriter writer = new StreamWriter(filename);

            Main.DataInit.Questions.ForEach(x => { serializer.Serialize(writer, x); });
                               

            writer.Close();
                Main.MainMenu();
            } catch 
            {
                Console.WriteLine("XML did not write");
            }

        }


    }
}

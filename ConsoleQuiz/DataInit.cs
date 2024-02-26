using ConsoleQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{

    internal class DataInit ()
    {
        private Main Main { get; }

        public List<User> Users { get; set; }

        public List<Question> Questions {  get; set; }  
        
        public List<Answer> Answers { get; set; }


        public DataInit (Main Main) : this()
        {
            this.Main = Main;

            Users = new List<User> ();
            Questions = new List<Question> ();
            Answers = new List<Answer> ();

            FillUsersList ();
            FillQuestionsList ();
            FillAnswersList ();
        }

        private void FillUsersList()
        {
            Users.Add(new User()
            {
                Username = "test",
                userPassword = "Test123",
                Email = "matijapavkovic74@gmail.com"

            });
        }

        private void FillQuestionsList()
        {
            Questions.Add(new Question()
            {
                Description = "What is the name of the most decorated warship in naval history?",
            });

            Questions.Add(new Question()
            {
                Description = "Complete the statement: \r\n\t\t\tAn if statement is a selection statement that allows more than one",
            });
        }

        private void FillAnswersList ()
        {
            Answers.Add(new Answer()
            {
                Text = "HMS Warspite",
                IsCorrect = true,
                Points = 10,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                Text = "USS Colorado",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                Text = "KM Scharnhorst",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                Text = "HMS Victory",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });
        }
    }
}

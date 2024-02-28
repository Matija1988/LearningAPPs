using ConsoleQuiz.Models;
using ConsoleQuiz.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{

    internal  class DataInit ()
    {
        private Main Main { get; }

        public List<User> _users { get; set; }

        public List<Question> Questions {  get; set; }  
        
        public List<Answer> Answers { get; set; }


        public DataInit (Main Main) : this()
        {
            this.Main = Main;

            _users = new List<User> ();
            Questions = new List<Question> ();
            Answers = new List<Answer> ();

            FillUsersList ();
            FillQuestionsList ();
            FillAnswersList ();
        }
                    
        private void FillUsersList()
        {
            _users.Add(new User()
            { 
                id = UserInputs.AutoIncrementID(_users),
                Username = "Matija",
                userPassword = "test",
                Email = "matijapavkovic74@gmail.com"

            }) ;
        }

        private void FillQuestionsList()
        {
            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "What is the name of the most decorated warship in naval history?",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Complete the statement: \r\n\t\t\tAn if statement is a selection statement that allows more than one",
            });
        }

        private void FillAnswersList ()
        {
            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "HMS Warspite",
                IsCorrect = true,
                Points = 10,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "USS Colorado",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "KM Scharnhorst",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "HMS Victory",
                IsCorrect = false,
                Points = 0,
                QuestionID = 1,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "operation",
                IsCorrect = false,
                Points = 0,
                QuestionID = 2,

            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "possible flow of control",
                IsCorrect = true,
                Points = 10,
                QuestionID = 2,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "method call",
                IsCorrect = false,
                Points = 0,
                QuestionID = 2,
            });

            Answers.Add(new Answer() 
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "insanity plea",
                IsCorrect = false,  
                Points = 0,
                QuestionID = 2,
            });
            
        }
    }
}

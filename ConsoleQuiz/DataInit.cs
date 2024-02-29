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

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Fill in the blank: \r\n\t\t\t_______ is the capital city of Spain.",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "C# is a ",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Who played the character of Joey Tribbiani in a popular sitcom Friends?",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Hydrogen is an explosive gas, oxygen fuels fires. Combine two atoms of hydrogen and one atom of oxygen and you get: ",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "What is in the middle of Trafalgar Square?",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Complete the formula: O= r * 2 * ?",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "The band that had a live concert on all seven contients is?",
            });

            Questions.Add(new Question()
            {
                id = UserInputs.AutoIncrementID(Questions),
                Description = "Fast inverse square root is best known for ",
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

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Sevila",
                IsCorrect = false,
                Points = 0,
                QuestionID = 3,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Valencia",
                IsCorrect = false,
                Points = 0,
                QuestionID = 3,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Barcelona",
                IsCorrect = false,
                Points = 0,
                QuestionID = 3,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Madrid",
                IsCorrect = true,
                Points = 10,
                QuestionID = 3,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Dynamically typed programing language",
                IsCorrect = false,
                Points = 0,
                QuestionID = 4,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Statically typed programing language",
                IsCorrect = true,
                Points = 10,
                QuestionID = 4,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "not sharp enough programing language",
                IsCorrect = false,
                Points = 0,
                QuestionID = 4,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "progressive programing language",
                IsCorrect = true,
                Points = 10,
                QuestionID = 4,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Matthew Perry",
                IsCorrect = false,
                Points = 0,
                QuestionID = 5,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "David Schwimmer",
                IsCorrect = false,
                Points = 0,
                QuestionID = 5,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Richard Burke",
                IsCorrect = false,
                Points = 0,
                QuestionID = 5,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Matt LeBlanc",
                IsCorrect = true,
                Points = 10,
                QuestionID = 5,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "the end of the world as we know it",
                IsCorrect = false,
                Points = 0,
                QuestionID = 6,
            });
            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "this is why we can't have nice things",
                IsCorrect = false,
                Points = 0,
                QuestionID = 6,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "dyhidrogenmonoxide aka water",
                IsCorrect = true,
                Points = 10,
                QuestionID = 6,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "nuclear fusion",
                IsCorrect = false,
                Points = 0,
                QuestionID = 6,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "The statue of Trafalgar",
                IsCorrect = false,
                Points = 0,
                QuestionID = 7,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Memorial to sailors lost at sea",
                IsCorrect = false,
                Points = 0,
                QuestionID = 7,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Nelson's column",
                IsCorrect = true,
                Points = 10,
                QuestionID = 7,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Statue of Henrik the VIII",
                IsCorrect = false,
                Points = 0,
                QuestionID = 7,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "π",
                IsCorrect = true,
                Points = 10,
                QuestionID = 8,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "m",
                IsCorrect = false,
                Points = 0,
                QuestionID = 8,
            });


            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "c",
                IsCorrect = false,
                Points = 0,
                QuestionID = 8,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "(x/2)*g",
                IsCorrect = false,
                Points = 0,
                QuestionID = 8,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "One direction",
                IsCorrect = false,
                Points = 0,
                QuestionID = 9,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Taylor Swift",
                IsCorrect = false,
                Points = 0,
                QuestionID = 9,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Metallica",
                IsCorrect = true,
                Points = 10,
                QuestionID = 9,
            });


            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "Soviet naval orchestra Murmansk",
                IsCorrect = false,
                Points = 0,
                QuestionID = 9,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "its use in Appolo mission navi computer",
                IsCorrect = false,
                Points = 0,
                QuestionID = 10,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "enabling quantom computation",
                IsCorrect = false,
                Points = 0,
                QuestionID = 10,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "aircraft fly by wire system",
                IsCorrect = false,
                Points = 0,
                QuestionID = 10,
            });

            Answers.Add(new Answer()
            {
                id = UserInputs.AutoIncrementID(Answers),
                Text = "implementation in Quake III Arena",
                IsCorrect = true,
                Points = 10,
                QuestionID = 10,
            });
        }
    }
}

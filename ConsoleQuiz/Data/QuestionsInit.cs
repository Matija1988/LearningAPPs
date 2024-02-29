using ConsoleQuiz.Models;
using ConsoleQuiz.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Data
{
    internal class QuestionsInit
    {
        public List<Question> Questions { get; set; }



        public QuestionsInit() { }

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
    }
}

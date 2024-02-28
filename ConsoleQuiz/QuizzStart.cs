using ConsoleQuiz.Models;
using ConsoleQuiz.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    internal class QuizzStart
    {
        private Main Main {  get; }

        private DataInit DataInit { get; }

        public QuizzStart(Main Main) : this()
        {
            this.Main = Main;
        }

        public QuizzStart() 
        { 
        
        }

        public void LoadQuestion()
        {

            int questionIndex = 0;
            

            var question = Main.DataInit.Questions[questionIndex];


            Console.WriteLine(question.ToString());

            LoadAnswers();
          

        }

        private void LoadAnswers ()
        {
            bool IsAnswered = false;

            int answer1 = 0;
            int answer2 = 1;
            int answer3 = 2;
            int answer4 = 3;    


            var answerText = Main.DataInit.Answers[answer1];
            var answerText1 = Main.DataInit.Answers[answer2];
            var answerText2 = Main.DataInit.Answers[answer3];
            var answerText3 = Main.DataInit.Answers[answer4];

            Console.WriteLine("1) " + answerText);
            Console.WriteLine("2) " + answerText1);
            Console.WriteLine("3) " + answerText2);
            Console.WriteLine("4) " + answerText3);


            switch (UserInputs.InputIntZeroAllowed("Enter your answer: "))
            {
                case 1:
                    if(answerText.IsCorrect)
                    {
                        IsAnswered = answerText.IsCorrect;
                        Console.WriteLine("Your answer is " + IsAnswered);
                    }
                    break;
                case 2:
                    if (answerText.IsCorrect)
                    {
                        IsAnswered = answerText1.IsCorrect;
                        Console.WriteLine("Your answer is " + IsAnswered);
                    }
                    break;
                case 3:
                    if (answerText.IsCorrect)
                    {
                        IsAnswered = answerText2.IsCorrect;
                        Console.WriteLine("Your answer is " + IsAnswered);
                    }
                    break;
                case 4:
                    if (answerText.IsCorrect)
                    {
                        IsAnswered = answerText3.IsCorrect;
                        Console.WriteLine("Your answer is " + IsAnswered);
                    }
                    break;
            }
        }
    }
}

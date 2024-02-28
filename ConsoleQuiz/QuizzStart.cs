using ConsoleQuiz.Models;
using ConsoleQuiz.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    internal class QuizzStart
    {
        private Main Main { get; }

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
            int score = 0;
          
            for(int i = 0; i < Main.DataInit.Questions.Count; i++) { 

            var question = Main.DataInit.Questions[i];
                        
                

            Console.WriteLine(question.ToString());

                int highscore =+ LoadAnswers(question, score);
                                 
                score = highscore;  

                Console.WriteLine("Your score is " + highscore);

            }

        }

        private int LoadAnswers(Question question, int score)
        {
            bool isAnswered = false;
            int counter = 1;
                      

            List<Answer> answerList = new List<Answer>();

            Main.DataInit.Answers.ForEach(a =>
            {
                if (a.QuestionID == question.id)
                {
                    answerList.Add(a);
                }
            });

            for (int i = 0; i < answerList.Count; i++)
            {
                Console.WriteLine(counter++ + ") " + answerList[i]);
            }

            switch (UserInputs.InputInt("Enter your answer: "))
            {
                case 1:
                    if (answerList.ElementAt(0).IsCorrect)
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(0).IsCorrect);
                        score += answerList.ElementAt(0).Points;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(0).IsCorrect);
                    }
                    break;

                case 2:
                    if (answerList.ElementAt(1).IsCorrect)
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(1).IsCorrect);
                        score += answerList.ElementAt(1).Points;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(1).IsCorrect);
                      
                    }
                    break;
                case 3:
                    if (answerList.ElementAt(2).IsCorrect)
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(2).IsCorrect);
                        score += answerList.ElementAt(2).Points;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(2).IsCorrect);
                    }
                    break;
                case 4:
                    if (answerList.ElementAt(3).IsCorrect)
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(3).IsCorrect);
                        score += answerList.ElementAt(3).Points;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is " + answerList.ElementAt(3).IsCorrect);
                    }
                    break;
                default:
                    ErrorMessages.ErrorMessageInput();
                    break;
            }

           

            return score;

        }
    }

}

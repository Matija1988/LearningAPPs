using ConsoleQuiz.Models;
using ConsoleQuiz.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    internal class Main
    {

        public DataInit DataInit { get; }

        public QuizzStart QuizzStart { get; }

        public XMLOutput XMLOutput { get; }

        public XMLRead XMLRead { get; }

        public List<User> _users { get; }
        public Main()
        {
            DataInit = new DataInit(this);
            QuizzStart = new QuizzStart(this);
            XMLOutput = new XMLOutput(this);
            XMLRead = new XMLRead(this);

            GraphicElements.StartMessage();
            LogIn();
        }



        public void LogIn()
        {
            GraphicElements.PrintStars();
            MenuText.LogIn();


            while (true)
            {
                string username = EnterUsername();
                string password = EnterPassword();

                try
                {


                    DataInit._users.ForEach(user =>
                    {

                        if (user.Username == username && user.userPassword == password)
                        {
                            Console.WriteLine("Welcome " + user.Username);

                            MainMenu();

                        }
                        else
                        {
                            ErrorMessages.ErrorMessageInput();
                        }
                    });

                }
                catch
                {
                    ErrorMessages.ErrorMessageInput();
                    LogIn();
                }
            }
        }

        public void MainMenu()
        {
            MenuText.MainMenuText();

            MainMenuSwitch();

        }

        private void MainMenuSwitch()
        {
            switch (UserInputs.InputIntZeroAllowed("Enter menu option: "))
            {
                case 1:
                    Console.WriteLine("Entering quizz");
                    QuizzStart.LoadQuestion();
                    break;
                case 2:
                    break;
                case 3:
                    XMLOutput.WriteToDocument();
                    break;
                case 4:
                    XMLRead.ReadXML();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    ErrorMessages.ErrorMessageInput();
                    break;
            }
        }

        private string EnterPassword()
        {
            string password = UserInputs.InputString("Password: ");

            char[] checker = password.ToCharArray();


            if (checker.Length == 0)
            {
                ErrorMessages.NoUserInput();
                EnterPassword();
            }

            if (!checker.Contains('[') || !checker.Contains('=') || !checker.Contains('(') || !checker.Contains(';'))
            {
                password = new string(checker);


            }
            else
            {
                ErrorMessages.InputContainsUnwantedCharacters();
                EnterPassword();
            }

            return password;
        }

        private static string EnterUsername()
        {
            string username = UserInputs.InputString("Username: ");

            char[] checker = username.ToCharArray();


            if (!checker.Contains('[') || !checker.Contains('=') || !checker.Contains('(') || !checker.Contains(';'))
            {
                username = new string(checker);


            }
            else
            {
                ErrorMessages.InputContainsUnwantedCharacters();
                EnterUsername();
            }

            return username;
        }


    }
}

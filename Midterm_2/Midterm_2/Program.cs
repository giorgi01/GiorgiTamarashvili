using System;

namespace Midterm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var userOption = Menu.GetUserOption();
                if (userOption == Option.StartTest)
                {
                    QuizManager.StartTest();
                }
                else if (userOption == Option.AddTest)
                {
                    QuizManager.AddTest();
                }
            }
            catch (SecondCorrectAnswerException ex)
            {
                Console.WriteLine("kitkhvis damatebisas mokhda shecdoma: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("mokhda shecdoma:" + ex.Message);
            }
        }
    }
}


using System;
using System.Collections.Generic;

namespace second_midterm_Giorgi_Tamarashvili
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
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

                ErrorLogger errorLogger = new ErrorLogger("custom_exceptions.txt");
                errorLogger.Subscribe(pub);

                pub.OnErrorOccured($"Error:  {ex.Message}, stack trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("mokhda shecdoma:" + ex.Message);

                ErrorLogger errorLogger = new ErrorLogger("errors.txt");  // ეს ორი სხვადასხვა ლოგი, უბრალოდ თვალსაჩინეობისთვის დავწერე
                errorLogger.Subscribe(pub);

                pub.OnErrorOccured($"Error:  {ex.Message}, stack trace: {ex.StackTrace}");
            }
        }
    }
}


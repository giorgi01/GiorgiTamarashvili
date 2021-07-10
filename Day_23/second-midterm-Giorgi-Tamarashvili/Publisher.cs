using System;
using System.Collections.Generic;
using System.Text;

namespace second_midterm_Giorgi_Tamarashvili
{
    public class Publisher
    {
        public delegate void Log(string message);
        public event Log ChoiceMade;
        public event Log ErrorOccured;
        public Publisher()
        {
        }

        public void OnChoiceMade(string message)
        {
            ChoiceMade?.Invoke(message);
        }

        public void OnErrorOccured(string errorMessage)
        {
            ErrorOccured?.Invoke(errorMessage);
        }
    } 
}


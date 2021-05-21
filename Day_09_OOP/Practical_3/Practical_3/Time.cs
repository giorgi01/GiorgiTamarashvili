using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value > 24 || value < 0)
                    Console.WriteLine("Invalid input");
                else if (value == 24)
                    _hours = 0;
                else
                    _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value > 59 || value < 0)
                    Console.WriteLine("Invalid input");
                else
                    _minutes = value;
            }
        }
        
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value > 59 || value < 0)
                    Console.WriteLine("Invalid input");
                else
                    _seconds = value;
            }
        }

        public void GetCurrentTime()
        {
            StringBuilder sb = new StringBuilder();

            if (_hours < 10) sb.Append("0");
            sb.Append(_hours);
            sb.Append(":");

            if (_minutes < 10) sb.Append("0");
            sb.Append(_minutes);
            sb.Append(":");

            if (_seconds < 10) sb.Append("0");
            sb.Append(_seconds);

            Console.WriteLine(sb);
        }

        public void AddHour()
        {
            if (_hours == 23)
                _hours = 0;
            else
                _hours += 1;
        }

        public void AddMinute()
        {
            if (_minutes == 59)
            {
                _minutes = 0;
                AddHour();
            }
            else
            {
                _minutes += 1;
            }
        }

        public void AddSecond()
        {
            if (_seconds == 59)
            {
                _seconds = 0;
                AddMinute();
            }
            else
            {
                _seconds += 1;
            }
        }

        public void SubtractHour()
        {
            if (_hours == 0)
                _hours = 23;
            else
                _hours -= 1;
        }

        public void SubtractMinute()
        {
            if (_minutes == 0)
            {
                _minutes = 59;
                SubtractHour();
            }
            else
            {
                _minutes -= 1;
            }
        }

        public void SubtractSecond()
        {
            if(_seconds == 0)
            {
                _seconds = 59;
                SubtractMinute();
            }
            else
            {
                _seconds -= 1;
            }
        }
    }
}

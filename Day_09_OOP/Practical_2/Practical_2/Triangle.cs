using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    class Triangle
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get
            {
                return _firstSide;
            }
            set
            {
                _firstSide = value;
            }
        }    
        public double SecondSide
        {
            get
            {
                return _secondSide;
            }
            set
            {
                _secondSide = value;
            }
        }
        public double ThirdSide
        {
            get
            {
                return _thirdSide;
            }
            set
            {
                bool isValidTriangle = _firstSide + _secondSide > value && _firstSide + value > _secondSide && _secondSide + value > _firstSide;
                if (isValidTriangle)
                    _thirdSide = value;
                else
                    Console.WriteLine("It is not a valid triangle");
            }
        }

        public double GetPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        public double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            double area = Math.Pow(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide), 0.5);

            return area;
        }
    }
}

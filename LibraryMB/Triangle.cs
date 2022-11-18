using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMB
{
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            //проверка на положительные стороны треугольника
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All of the sides should be more then 0");
            }

            //проверка на существование треугольника
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Triangle with these sides doesn't exist");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateSquare()
        {
            double halfOfPerimetr = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(halfOfPerimetr * (halfOfPerimetr - _sideA) * (halfOfPerimetr - _sideB) * (halfOfPerimetr - _sideC));
        }

        public bool IsRightTriangle()
        {
            //проверка на прямоугольный треугольник
            //если кваодрат большей стороны равен сумме квадратов двух дургих сторон,
            //то треугольник прямоугольный
            if (_sideA > _sideB & _sideA > _sideC)
                return  Math.Pow(_sideA, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);
            else if (_sideB > _sideC) 
                return Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2);
            else return Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2);

        }
    }
}

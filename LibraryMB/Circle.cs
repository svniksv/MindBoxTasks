using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMB
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            //проверка на положительный радиус
            if(radius <= 0)
            {
                throw new ArgumentException("Radius need to be more then 0");
            }
            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
}

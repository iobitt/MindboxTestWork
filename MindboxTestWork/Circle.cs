using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestWork
{
    // Геометрическая фигура круг
    public class Circle : GeometricFigure
    {
        // Радиус круга
        double R { get; }

        public Circle(double R)
        {
            if (R < 0)
                throw new ArgumentOutOfRangeException("Радиус должен быть не отрицательным числом!");

            this.R = R;
        }

        // Переопределенный метод вычисления площади
        public override double GetSquare()
        {
            return Math.PI * R * R;
        }
    }
}

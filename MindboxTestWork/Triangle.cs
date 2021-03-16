using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestWork
{
    public class Triangle : GeometricFigure
    {
        // Стороны треугольника
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть положительными числами!");

            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует!");
            }
        }

        // Переопределенный метод вычисления площади
        public override double GetSquare()
        {
            // Полупериметр
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Возвращает true, если треугольник прямоугольный
        public bool IsRectangular()
        {
            // Определим, какая сторона является гипотенузой, а какие катетами
            double hypotenuse, cathetus1, cathetus2;
            if (c > a && c > b)
            {
                hypotenuse = c;
                cathetus1 = a;
                cathetus2 = b;
            }
            else if (a > c && a > b)
            {
                hypotenuse = a;
                cathetus1 = c;
                cathetus2 = b;
            }
            else
            {
                hypotenuse = b;
                cathetus1 = a;
                cathetus2 = c;
            }

            // По теореме Пифагора проверяем является ли треугольник прямоугольным
            if (Math.Pow(hypotenuse, 2) == Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2))
                return true;
            else return false;
        }
    }
}

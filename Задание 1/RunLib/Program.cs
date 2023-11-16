using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateArea;

namespace RunLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            Console.WriteLine($"Является ли прямоугольным? {triangle.IsRightTriangle()}");
            Console.ReadKey();
        }
    }
}

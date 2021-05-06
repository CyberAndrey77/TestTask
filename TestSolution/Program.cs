using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading.Channels;
using FigureArea;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetTriangleArea();
            //GetCircleArea();
            CheckRightTriangle();
        }

        private static void GetTriangleArea()
        {
            int countSide = 3;
            List<double> figureParams = new List<double>();

            for (int i = 0; i < countSide; i++)
            {
                Console.WriteLine($"Введите {i + 1} сторону треугольника");
                double side = 0;
                while (!(double.TryParse(Console.ReadLine(), out side)))
                {
                    Console.WriteLine("Введите число!!!");
                    Console.WriteLine($"Введите {i + 1} сторону треугольника");
                }
                figureParams.Add(side);
            }
            
            var triangle = new Triangle();
            triangle.FindFigureArea(figureParams);

            if (triangle.Area > 0)
            {
                Console.WriteLine($"Площадь треугольника равна {triangle.Area}");
            }
            else
            {
                Console.WriteLine("Это не треугольник!");
            }
        }

        private static void GetCircleArea()
        {
            List<double> figureParams = new List<double>();
            Console.WriteLine("Введите радиус круга");
            double side = 0;
            while (!(double.TryParse(Console.ReadLine(), out side)))
            {
                Console.WriteLine("Введите число!!!");
                Console.WriteLine($"Введите радиус круга");
            }
            figureParams.Add(side);

            var circle = new Circle();
            circle.FindFigureArea(figureParams);
            if (circle.Area > 0)
            {
                Console.WriteLine($"Площадь круга равна {circle.Area}");
            }
            else
            {
                Console.WriteLine("Это не круг!");
            }
        }

        private static void CheckRightTriangle()
        {
            int countSide = 3;
            List<double> figureParams = new List<double>();

            for (int i = 0; i < countSide; i++)
            {
                Console.WriteLine($"Введите {i + 1} сторону треугольника");
                double side = 0;
                while (!(double.TryParse(Console.ReadLine(), out side)))
                {
                    Console.WriteLine("Введите число!!!");
                    Console.WriteLine($"Введите {i + 1} сторону треугольника");
                }
                figureParams.Add(side);
            }

            var triangle = new Triangle();

            try
            {
                if (triangle.IsTriangleRight(figureParams))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Не является треугольником.");
            }
        }
    }
}

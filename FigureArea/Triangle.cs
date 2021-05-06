using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigureArea.Base;

namespace FigureArea
{
    public class Triangle: BaseFigure
    {
        /// <summary>
        /// Метод для получения площади фигуры. 
        /// </summary>
        /// <param name="figureParams">Параметры фигуры. Для треугольника три стороны.</param>
        /// <returns>Возвращает площадь фигуры и 0 если это не треугольник.</returns>
        public override double FindFigureArea(List<double> figureParams)
        {
            if (!CheckTriangle(figureParams))
            {
                return 0;
            }
            
            // Полупериметор.
            var p = (figureParams[0] + figureParams[1] + figureParams[2]) / 2;

            Area = Math.Sqrt(p * (p - figureParams[0]) * (p - figureParams[1]) * (p - figureParams[2]));

            return Area;
        }

        /// <summary>
        /// Позволяет определить является ли треугольник прямоугольным. Выбрасывает исключение если это не треугольник.
        /// </summary>
        /// <param name="figureParams">Параметры треугольника. В данном случае три стороны.</param>
        /// <returns>Возвращает true если треугольник прямоугольный треугольник, иначе false.</returns>
        public bool IsTriangleRight(List<double> figureParams)
        {
            if (!CheckTriangle(figureParams))
            {
                throw new ArgumentException();
            }

            var hypotenuse = figureParams.Max();
            List<double> cathets = new List<double>();

            foreach (var param in figureParams)
            {
                if (param != hypotenuse)
                {
                    cathets.Add(param);
                }
            }

            if (Math.Pow(cathets[0], 2) + Math.Pow(cathets[1], 2) != Math.Pow(hypotenuse, 2))
            {
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Делает проверку на существование треугольника.
        /// </summary>
        /// <param name="figureParams"> Параметры фигуры, в данном случает стороны треугольника.</param>
        /// <returns>Возвращает true, если фигура треугольник, false если не треугольник.</returns>
        public static bool CheckTriangle(List<double> figureParams)
        {
            foreach (var param in figureParams)
            {
                if (param < 0)
                {
                    return false;
                }
            }

            return figureParams[0] + figureParams[1] > figureParams[2]
                   && figureParams[1] + figureParams[2] > figureParams[0]
                   && figureParams[2] + figureParams[0] > figureParams[1];
        }
    }
}

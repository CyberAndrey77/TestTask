using System;
using System.Collections.Generic;
using FigureArea.Base;

namespace FigureArea
{
    public class Circle : BaseFigure
    {
        /// <summary>
        /// Метод вычисляющий площадь круга.
        /// </summary>
        /// <param name="figureParams">Параметры круга. В данном случае радиус.</param>
        /// <returns>Возвращает площадь круга и 0 если круга не существует.</returns>
        public override double FindFigureArea(List<double> figureParams)
        {
            if (figureParams[0] < 0)
            {
                return 0;
            }

            Area = Math.Pow(figureParams[0], 2) * Math.PI;
            return Area;
        }
    }
}

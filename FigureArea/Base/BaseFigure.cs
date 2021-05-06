using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea.Base
{
    public class BaseFigure
    {
        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area { get; set; }

        public virtual double FindFigureArea(List<double> figureParams)
        {
            return 0;
        }
    }
}

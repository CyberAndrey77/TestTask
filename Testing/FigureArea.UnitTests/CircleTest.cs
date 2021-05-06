using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FigureArea.UnitTests
{
    class CircleTest
    {
        private Circle _circle;
        [SetUp]
        public void Setup()
        {
            _circle = new Circle();
        }

        [Test(Description = "Тестирование площади окружности при существовании круга.")]
        public void FindFigureArea_CorrectValue_ResultCorrectValue()
        {
            //Setup
            var expectedArea = 100 * Math.PI;
            var figureParams = new List<double> {10};

            //Act
            var actualArea = _circle.FindFigureArea(figureParams);

            //Assert
            Assert.AreEqual(actualArea, expectedArea);
        }

        [Test(Description = "Тестирование площади окружности, когда круга не существует.")]
        public void FindFigureArea_IncorrectValue_ResultCorrectValue()
        {
            //Setup
            var expectedArea = 0;
            var figureParams = new List<double> { 0 };

            //Act
            var actualArea = _circle.FindFigureArea(figureParams);

            //Assert
            Assert.AreEqual(actualArea, expectedArea);
        }
    }
}

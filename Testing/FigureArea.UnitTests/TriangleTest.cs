using System;
using System.Collections.Generic;
using NUnit.Framework;
using FigureArea;

namespace FigureArea.UnitTests
{
    public class TriangleTest
    {
        private Triangle _triangle;
        [SetUp]
        public void Setup()
        {
            _triangle = new Triangle();
        }

        [Test(Description = "������������ ������� ��� ���������� ��������� ������ ������������.")]
        public void FindFigureArea_CorrectValue_ResultCorrectValue()
        {
            //Setup
            double expectedArea = 24.0;
            List<double> figureParams = new List<double>() {6.0, 8.0, 10.0};

            //Act
            double actualArea = _triangle.FindFigureArea(figureParams);

            //Assert
            Assert.AreEqual(actualArea, expectedArea);
        }

        [Test(Description = "������������ ������� ������������ ��� ���������, ����� ����������� �� ����������.")]
        public void FindFigureArea_IncorrectValue_ResultCorrectValue()
        {
            //Setup
            double expectedArea = 0.0;
            List<double> figureParams = new List<double>() { 6.0, 8.0, 20.0 };

            //Act
            double actualArea = _triangle.FindFigureArea(figureParams);

            //Assert
            Assert.AreEqual(actualArea, expectedArea);
        }

        [Test(Description = "������������ �������� �������� �� ����������� ������������� ��� ��������, ����� ����������� ����������.")]
        public void IsTriangleRight_�orrectValue_ResultCorrectValue()
        {
            //Setup
            var expected = true;
            List<double> figureParams = new List<double>() { 3.0, 4.0, 5.0 };

            //Act
            var actual = _triangle.IsTriangleRight(figureParams);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test(Description = "������������ �������� �������� �� ����������� ������������� ��� ��������, ����� ����������� ����������, �� �� �������������")]
        public void IsTriangleRight_IncorrectValue_ResultCorrectValue()
        {
            //Setup
            var expected = false;
            List<double> figureParams = new List<double>() { 6.0, 8.0, 7.0 };

            //Act
            var actual = _triangle.IsTriangleRight(figureParams);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test(Description = "������������ �������� �������� �� ����������� ������������� ��� ��������, ����� ����������� ����������, �� �� �������������")]
        public void IsTriangleRight_IncorrectValue_ArgumentException()
        {
            //Setup
            var expected = false;
            List<double> figureParams = new List<double>() { 6.0, 5.0, 20.0 };
            
            //Assert
            Assert.Throws<ArgumentException>(() => 
                //Act
                _triangle.IsTriangleRight(figureParams));
        }
    }
}
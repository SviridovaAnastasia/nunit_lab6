using NUnit.Framework;
using System;
using GeometricFigures;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {

        static object[] TriangleFigure =
        {
                new object[] { 0, 0, 0 },
                new object[] { 1, 1, 1 },
                new object[] { 2, 2, 2 },
                new object[] { 3, 3, 3 },
                new object[] { 4, 4, 4 },
                new object[] { 5, 5, 5 },
                new object[] { 6, 6, 6 },
                new object[] { 7, 7, 7 },
                new object[] { 8, 8, 8 },
                new object[] { 9, 9, 9 },
                new object[] { 10, 10, 10 },
                new object[] { 11, 11, 11 },
                new object[] { 12, 12, 12 },
                new object[] { 13, 13, 13 },
                new object[] { 14, 14, 14 },
                new object[] { 15, 15, 15 },
                new object[] { 16, 16, 16 },
                new object[] { 17, 17, 17 },
                new object[] { 18, 18, 18 },
                new object[] { 19, 19, 19 },
                new object[] { 20, 20, 20 }

        };

        static object[] SquareFigure =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        static object[] CircleFigure =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

 

        [Test, TestCaseSource("SquareFigure")]
        public void SquareArea(int a)
        {

            Square square = new Square(a);
            double area = a * a;
            Assert.AreEqual(Math.Floor(area), Math.Floor(square.getAreaSquare()));

        }

        [Test, TestCaseSource("SquareFigure")]
        public void SquareLenght(int a)
        {

            Square square = new Square(a);
            double lenght = 4 * a;
            Assert.AreEqual(lenght,square.getLengthSquare());

        }

        [Test, TestCaseSource("TriangleFigure")]
        public void TriangleLenght(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a, b, c);
            double lenght = a+b+c;
            Assert.AreEqual(Math.Floor(lenght), Math.Floor(triangle.getLengthTriangle()));

        }

        [Test, TestCaseSource("TriangleFigure")]
        public void TriangleArea(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a, b, c);
            double p = 0.5 * (a+b+c);
            double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Assert.AreEqual(Math.Floor(area), Math.Floor(triangle.getAreaTriangle()));
        }
        [Test, TestCaseSource("CircleFigure")]

        public void CircleArea(int a)
        {

            Circle circle = new Circle(a);
            double area = 3.141593 * a * a;
            Assert.AreEqual(Math.Floor(area), Math.Floor(circle.getAreaCircle()));

        }

        [Test, TestCaseSource("CircleFigure")]
        public void CircleLenght(int a)
        {

            Circle circle = new Circle(a);
            double lenght = 2 * 3.141593 * a;
            Assert.AreEqual(Math.Floor(lenght), Math.Floor(circle.getLengthCircle()));

        }
        [Test]
        public void TestCircleString()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("error"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestCircleFloat()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("0.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestCircleNegative()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(-100);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }

        [Test]
        public void TestSquareString()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(Convert.ToInt32("error"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareFloat()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(Convert.ToInt32("0.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestSquareNegative()
        {
            Exception exception = null;
            try
            {
                Square square = new Square(-100);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Console.WriteLine(exception);
            Assert.IsNotNull(exception);
        }

        [Test]
        public void TestTriangleString()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(0,0,0);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleFloat()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("0.5"), Convert.ToInt32("0.5"), Convert.ToInt32("0.5"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }

        [Test]
        public void TestTriangleNumberMines()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(-10, -10, -10);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}

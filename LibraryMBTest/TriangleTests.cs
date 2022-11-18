using LibraryMB;


namespace LibraryMBTest
{
    using LibraryMB;
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        //проврка вычисления площади треугольника при корректных данных
        public void CalculateRigthSquareOfTriangle()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 10;
            var triangle = new Triangle(sideA, sideB, sideC);

            double result = triangle.CalculateSquare();
            double expected = 24;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //проврека с отрицательным занчением стороны
        public void CalculateSquareOfTriangleWithNegativeSide()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(6,8,-10));
        }

        [TestMethod]
        //проверка на несуществующем треугольнике
        public void CalculateSquareOfNonExistentTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(7,12, 29));
        }

        [TestMethod]
        //проверка на прямоугольный треугольник с корректными данными
        public void TriangleIsRight()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 10;
            var triangle = new Triangle(sideA, sideB, sideC);

            bool result = triangle.IsRightTriangle();
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }
    }
}
using LibraryMB;

namespace LibraryMBTest
{
    
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        //проверка вычисления площади круга на корректных данных
        public void CalculateRightSquareOfCircle()
        {
            double radius = 5;
            var circle = new Circle(radius);

            double result = circle.CalculateSquare();
            double expected = 78.53981633974483;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        //проверка при отрицательном радиусе
        public void CalculateSquareOfCircleWithNegativeNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-7));
        }

        [TestMethod]
        //проверка при радиусе = 0
        public void CalculateSquareOfCircleWithZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }
    }
}
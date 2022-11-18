using LibraryMB;


namespace LibraryMBTest
{
    using LibraryMB;
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        //������� ���������� ������� ������������ ��� ���������� ������
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
        //�������� � ������������� ��������� �������
        public void CalculateSquareOfTriangleWithNegativeSide()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(6,8,-10));
        }

        [TestMethod]
        //�������� �� �������������� ������������
        public void CalculateSquareOfNonExistentTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(7,12, 29));
        }

        [TestMethod]
        //�������� �� ������������� ����������� � ����������� �������
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
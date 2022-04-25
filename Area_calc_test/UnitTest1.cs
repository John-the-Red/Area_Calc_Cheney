using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Calc_Cheney;
namespace Area_calc_test
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void IntSquareArea()
        {
            Assert.AreEqual(100, AreaCalculator.getSquareArea(10));
        }
        [TestMethod]
        public void StringSquareArea()
        {
            Assert.AreEqual(100, AreaCalculator.getSquareArea("Ten"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void FailedStringSquareArea()
        {
            Assert.AreEqual(100, AreaCalculator.getSquareArea("John"));
        }
        [TestMethod]
        public void IntRectangleArea()
        {
            Assert.AreEqual(50, AreaCalculator.getRectangleArea(10, 5));
        }
        [TestMethod]
        public void IntParallelogramArea()
        {
            Assert.AreEqual(50, AreaCalculator.getParallelogramArea(10, 5));
        }
        [TestMethod]
        public void IntTriangleArea()
        {
            Assert.AreEqual(7.5, AreaCalculator.getTriangleArea(3, 5));
        }
        [TestMethod]
        public void IntCircleRadius()
        {
            Assert.AreEqual(4, AreaCalculator.getCircleRadius(8));
        }
        [TestMethod]
        public void IntCircleDiameter()
        {
            Assert.AreEqual(10, AreaCalculator.getCircleDiameter(5));
        }
    }
}
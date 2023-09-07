using CalcFigureLib;

namespace CalcFigureLibTest
{
    public class CalcTriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CalcSqureTest()
        {
            double square = new Triangle(4,2,3).CalcSqure();

            double expected = 2.904;

            Assert.That(square, Is.EqualTo(expected).Within(1e-6));
        }

        [Test]
        public void NegativeEdgeTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(-1, 1, 4));
        }

        [TestCase(2,3,6, ExpectedResult = false)]
        [TestCase(5, 3, 4, ExpectedResult = true)]
        public bool GetIsTriangleRight(double edgeA, double edgeB, double edgeC)
        {
            Triangle triangle = new Triangle(edgeA, edgeB, edgeC);

            return triangle.GetIsTriangleRight();
        }
    }
}

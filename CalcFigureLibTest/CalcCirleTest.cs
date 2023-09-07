using CalcFigureLib;

namespace CalcFigureLibTest
{
    public class CalcCircleTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CalcSqureTest()
        {
            int radius = 10;

            double square = new Circle(radius).CalcSqure();
            
            double expected = 314;

            Assert.That(square, Is.EqualTo(expected).Within(0.2));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(()=> new Circle(-1));
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }
    }
}
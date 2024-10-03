using NUnitTaskLibrary;
using NSubstitute;
using System.Diagnostics;

namespace NUnitTask
{
    public class NumberProcessorTest
    {
        private INumberService? numberService;
        private NumberProcessor? processor;

        [SetUp]
        public void Setup()
        {
            numberService = Substitute.For<INumberService>();
            numberService.GetIntArray().Returns([1, 2, 3]);

            processor = new(numberService);
        }

        [Test]
        public void SumTest()
        {
            Assert.That(processor!.CalculateSum(), Is.EqualTo(6));
        }

        [Test]
        public void AverageTest()
        {
            Assert.That(processor!.CalculateAverage(), Is.EqualTo(2f));
        }
    }
}
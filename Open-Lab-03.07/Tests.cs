using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_03._07
{
    [TestFixture]
    public class Tests
    {

        private Divider divider;

        private const int RandSeed = 307307307;
        private const int RandMaxTotal = 10000;
        private const int RandTestCasesCount = 95;

        [OneTimeSetUp]
        public void Init() => divider = new Divider();

        [TestCase(11, 5, 2, true)]
        [TestCase(11, 5, 3, false)]
        [TestCase(8, 3, 2, true)]
        [TestCase(8, 3, 3, false)]
        [TestCase(24, 12, 2, true)]
        [TestCaseSource(nameof(GetRandom))]
        public void EqualSlicesTest(int total, int people, int each, bool expected) =>
            Assert.That(divider.EqualSlices(total, people, each), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var random = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var total = random.Next(RandMaxTotal + 1);
                var people = random.Next(total);
                var each = random.Next(1, total / people + 5);

                yield return new TestCaseData(total, people, each, people * each <= total);
            }
        }

    }
}

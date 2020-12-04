using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTest
{
    public class PotterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var target = new Potter();
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            decimal actual = target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_ListWithOneBook_Return8()
        {
            var target = new Potter();
            var countOfSameBooks = new List<int>() { 1 };
            var expected = 8m;

            decimal actual = target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
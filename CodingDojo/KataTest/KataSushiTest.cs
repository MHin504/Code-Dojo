using System.Collections.Generic;
using NUnit.Framework;

namespace KataTest
{
    public class KataSushiTest
    {
        private List<DishColor> basket ;

        [SetUp]
        public void Setup()
        {
            basket = new List<DishColor>();
        }

        [Test]
        public void Calculate_EmptyBasket_Return0()
        {
            var expected = 0m;

            ActAndAssert(expected);
        }

        private void ActAndAssert(decimal expected)
        {
            var actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneBlue_Return095()
        {
            basket.Add(DishColor.Blue);
            var expected = 0.95m;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_OneRed_Return195()
        {
            basket.Add(DishColor.Red);
            var expected = 1.95m;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_OneYellow_Return295()
        {
            basket.Add(DishColor.Yellow);
            var expected = 2.95m;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_OneGreen_Return395()
        {
            basket.Add(DishColor.Green);
            var expected = 3.95m;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_OneGray_Return495()
        {
            basket.Add(DishColor.Gray);
            var expected = 4.95m;

            ActAndAssert(expected);
        }
 
        [Test]
        public void Calculate_TwoBlue_Return190()
        {
            basket.Add(DishColor.Blue);
            basket.Add(DishColor.Blue);
            var expected = 1.90m;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_TwoRed_Return390()
        {
            basket.Add(DishColor.Red);
            basket.Add(DishColor.Red);
            var expected = 1.95m * basket.Count;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_TwoYellow_Return590()
        {
            basket.Add(DishColor.Yellow);
            basket.Add(DishColor.Yellow);
            var expected = 2.95m * basket.Count;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_TwoGreen_Return790()
        {
            basket.Add(DishColor.Green);
            basket.Add(DishColor.Green);
            var expected = 3.95m * basket.Count;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_TwoGray_Return990()
        {
            basket.Add(DishColor.Gray);
            basket.Add(DishColor.Gray);
            var expected = 4.95m * basket.Count;

            ActAndAssert(expected);
        }

        [Test]
        public void Calculate_OneBlueOneRed_Return290()
        {
            basket.Add(DishColor.Blue);
            basket.Add(DishColor.Red);
            var expected = 2.90m;

            ActAndAssert(expected);
        }
    }
}
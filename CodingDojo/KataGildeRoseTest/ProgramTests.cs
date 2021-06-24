// -----------------------------------------------------------------------
// <copyright file="ProgramTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataGildeRoseTest
{
    using KataGildedRose;
    using NUnit.Framework;

    public class ProgramTests
    {
        private Program _target;

        [SetUp]
        public void Setup()
        {
            _target = new Program();
        }

        [Test]
        public void PublicItems_DoesExist_AssertsTrue()
        {
            Assert.That(_target.PublicItems, Is.Null);
        }
    }
}

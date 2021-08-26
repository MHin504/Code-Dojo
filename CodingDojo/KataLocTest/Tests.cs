﻿using System;
using NUnit.Framework;

namespace KataLocTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Count_StringInput_ReturnsZero()
        {
            var target = new LinesOfCode();
            var input = string.Empty;
            var expected = 0;

            var actual = target.Count(input);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

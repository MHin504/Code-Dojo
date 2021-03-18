﻿using System.Collections.Generic;
using KataBankOcr;
using KataBankOcr.Interfaces;
using NUnit.Framework;

namespace KataTest
{
    using System;

    [TestFixture]
    public class ReaderTests
    {
        private IReader _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Reader();
        }

        [Test]
        public void Read_NullArgument_ThrowsArgumentNullException()
        {
            string filename = null;

            Assert.Throws<ArgumentNullException>(() => _target.Read(filename));
        }

        [Test]
        public void Read_EmptyArgument_ThrowsArgumentException()
        {
            var filename = string.Empty;

            Assert.Throws<ArgumentException>(() => _target.Read(filename));
        }
        
        [Test]
        public void Read_File_ReturnListOfLine()
        {
            var filename = "filewithfourlines.txt";
            var expected = 4;

            var actual = _target.Read(filename);

            Assert.That(actual, Is.TypeOf<List<Line>>());
            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}

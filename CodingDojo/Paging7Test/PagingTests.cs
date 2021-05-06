﻿// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7Test
{
    using NUnit.Framework;
    using Paging7;

    [TestFixture]
    public class PagingTests
    {
        [TestCase(0, 0, "")]
        [TestCase(1, 1, "(1)")]
        [TestCase(2, 1, "(1) 2")]
        [TestCase(3, 1, "(1) 2 3")]
        [TestCase(4, 1, "(1) 2 3 4")]
        [TestCase(7, 1, "(1) 2 3 4 5 6 7")]
        [TestCase(7, 2, "1 (2) 3 4 5 6 7")]
        [TestCase(7, 4, "1 2 3 (4) 5 6 7")]
        [TestCase(7, 7, "1 2 3 4 5 6 (7)")]
        [TestCase(3, 3, "1 2 (3)")]
        public void GetPaging_InputParameter_ReturnsExpected(int pages, int currentPage, string expected)
        {
            var target = new Paging();

            var actual = target.GetPaging(pages, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
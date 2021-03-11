// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using KataBankOcr;
using KataBankOcr.Interfaces;
using NSubstitute;

namespace KataTest
{
    using NUnit.Framework;

    public class BankOcrTests
    {
        private BankOcr _target;
        private IReader _reader;
        private ILineSplitter _lineSplitter;
        private IEntryParser _entryParser;
        private string _filename = @"../../accountNumbers.txt";

        [SetUp]
        public void Setup()
        {
            _reader = Substitute.For<IReader>();
            _lineSplitter = Substitute.For<ILineSplitter>();
            _entryParser = Substitute.For<IEntryParser>();
            _target = new BankOcr(_reader, _lineSplitter, _entryParser);
        }

        [Test]
        public void Ctor_InjectAllDependencies_AllDependenciesWereInjected()
        {
            BankOcr target = new BankOcr(_reader, _lineSplitter, _entryParser);
        }

        [Test]
        public void Scan_EmptyFile_ReturnsEmptyListOfAccountNumbers()
        {
            var expected = new List<AccountNumber>();

            var actual = _target.Scan(_filename);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Scan_EmptyFile_MethodReadWasCalled()
        {
            _target.Scan(_filename);

            _reader.Received(1).Read(_filename);
        }
    }
}

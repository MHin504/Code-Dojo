// -----------------------------------------------------------------------
// <copyright file="BankOcr.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System.Collections.Generic;

    public class BankOcr
    {
        public BankOcr()
        {
        }

        public BankOcr(IReader reader)
        {
        }

        public List<AccountNumber> ScanFile(string fileName)
        {
            return new List<AccountNumber>();
        }
    }
}

// -----------------------------------------------------------------------
// <copyright file="IEntryParser.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Kata
{
    using System.Collections.Generic;

    public interface IEntryParser
    {
        List<AccountNumber> Parse(List<Entry> entries);
    }
}

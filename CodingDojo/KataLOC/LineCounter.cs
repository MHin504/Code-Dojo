﻿// -----------------------------------------------------------------------
// <copyright file="LineCounter.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOC
{
    using System;
    using System.Linq;

    public class LineCounter
    {
        public int Count(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return 0;
            }

            var lines = code.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return lines.Count(line => !line.StartsWith("//") && (!line.StartsWith("/*") || !line.EndsWith("*/")));
        }
    }
}

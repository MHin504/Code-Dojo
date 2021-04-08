﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KataBankOcr.Interfaces;

namespace KataBankOcr
{
    public class Reader : IReader
    {
        public List<Line> Read(string filename)
        {
            if (filename == string.Empty) throw new ArgumentException(nameof(filename));

            if (filename == null) throw new ArgumentNullException();

            return File.ReadAllLines(filename).Select(line => new Line() {Text = line}).ToList();
        }
    }
}
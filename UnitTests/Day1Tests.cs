using AdventOfCode2023;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;


internal class Day1Tests
{
    [Test]
    public void SingleLine()
    {
        const string input = "12";
        const int expected = 12;

        var result = Day1.Q1(input);

        NUnit.Framework.Assert.Equals(expected, result);
    }
}

using AdventOfCode2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTests;
public class Day1Tests
{
    [Fact]
    public void SingleLine()
    {
        const string input = "12";
        const int expected = 12;

        var result = Day1.Q1(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleValue()
    {
        const string input = "1";
        const int expected = 11;
        var result = Day1.Q1(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleLineWithChars()
    {
        const string input = "a1bbb2";
        const int expected = 12;
        var result = Day1.Q1(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultiLine()
    {
        const string input = @"1abc2
pqr3stu8vwx
a1b2c3d4e5f
treb7uchet";
        const int expected = 142;
        var result = Day1.Q1(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Blank()
    {
        const string input = "aaaaaaa";
        const int expected = 0;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleWord()
    {
        const string input = "seven";
        const int expected = 77;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordOne()
    {
        const string input = "one";
        const int expected = 11;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordTwo()
    {
        const string input = "two";
        const int expected = 22;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordThree()
    {
        const string input = "three";
        const int expected = 33;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordFour()
    {
        const string input = "four";
        const int expected = 44;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordFive()
    {
        const string input = "five";
        const int expected = 55;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordSix()
    {
        const string input = "six";
        const int expected = 66;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordSeven()
    {
        const string input = "seven";
        const int expected = 77;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordEight()
    {
        const string input = "eight";
        const int expected = 88;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact] public void WordNine()
    {
        const string input = "nine";
        const int expected = 99;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultiWord()
    {
        const string input = "oneseven";
        const int expected = 17;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordNumberCombo()
    {
        const string input = "two1nine";
        const int expected = 29;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WordWithFalseLetters()
    {
        const string input = "xsevenx";
        const int expected = 77;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CombinedWordsFalse()
    {
        const string input = "eightwothree";
        const int expected = 83;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CombinedWordsTrue()
    {
        const string input = "sevenine";
        const int expected = 79;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultiLineWordWithFalseLetters()
    {
        const string input = @"two1nine
eightwothree";

        const int expected = 112;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WomboCombo()
    {
        const string input = @"two1nine
eightwothree
abcone2threexyz
xtwone3four
4nineeightseven2
zoneight234
7pqrstsixteen";

        const int expected = 281;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Tricky()
    {
        const string input = "n4onetwoninexnvstftnchzfxzrqts";
        var expected = 49;
        var result = Day1.Q1(input);
        Assert.Equal(expected, result);
    }
}

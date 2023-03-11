using Xunit;
using FluentAssertions;
using Jogadev.CTCI.Problems.Chapter1;
using System;

namespace Jogadev.CTCI.Tests.Chapter1;

public class Q2_Tests 
{
    private static readonly CheckPermutation _solution = new CheckPermutation();

    [Theory]
    [InlineData("ABC", "ABCD")]
    [InlineData("QWERTYUIOP", "QWERTYUIO")]
    [InlineData("123456789", "1234567890")]
    public static void Different_Length_Strings_Are_Not_Permutations(string s1, string s2)
    {
        _solution.ExecuteSolution(Tuple.Create(s1, s2)).Should().BeFalse();
    }

    [Theory]
    [InlineData("QWERTYUIOP", "POIUYTREWQ")]
    [InlineData("ABCDEFG", "GFEDCBA")]
    [InlineData("123456789", "456321789")]
    public static void Solves_Positive_Cases(string s1, string s2)
    {
        _solution.ExecuteSolution(Tuple.Create(s1, s2)).Should().BeTrue();
    }

    [Theory]
    [InlineData("QWERTYUIOP", "QWERTYUIOO")]
    [InlineData("ABCDEFGH", "HGEEDCBA")]
    [InlineData("A", "B")]
    [InlineData("123456789", "023456789")]
    public static void Solves_Negative_Cases(string s1, string s2)
    {
        _solution.ExecuteSolution(Tuple.Create(s1, s2)).Should().BeFalse();
    }
}
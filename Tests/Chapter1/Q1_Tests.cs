using Xunit;
using FluentAssertions;
using Jogadev.CTCI.Problems.Chapter1;

namespace Jogadev.CTCI.Tests.Chapter1;

public class Q1_Tests 
{
    private static readonly IsUnique _solution = new IsUnique();

    [Theory]
    [InlineData("QWERTYUIOPASDFGHJKLZXCVBNM")]
    [InlineData("1234567890")]
    [InlineData("!#$%&/()?")]
    [InlineData("ABCD1234EFGH")]
    public static void Solves_Positive_Cases(string testString)
    {
        _solution.ExecuteSolution(testString).Should().BeTrue();
    }

    [Theory]
    [InlineData("AA")]
    [InlineData("ASDFGHJKLL")]
    [InlineData("QWERTYUIOPQ")]
    [InlineData("12345678905")]
    public static void Solves_Negative_Cases(string testString)
    {
        _solution.ExecuteSolution(testString).Should().BeFalse();
    }

}
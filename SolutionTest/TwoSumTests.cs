using FluentAssertions;
using Solution;

namespace SolutionTest;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 17, new int[] { 0, 3 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void Test1(int[] input, int target, int[] expected)
    {
        var result = Solver.TwoSum(input, target);

        result.Should().BeEquivalentTo(expected);
    }

}
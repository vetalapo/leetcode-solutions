using NUnit.Framework;

using Problems;

namespace Greedy;

public class MinimumCostOfBuyingCandiesWithDiscountTests
{
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = 5 )]
    [TestCase( new int[] { 6, 5, 7, 9, 2, 2 }, ExpectedResult = 23 )]
    [TestCase( new int[] { 5, 5 }, ExpectedResult = 10 )]
    public int MinimumCostTest( int[] cost ) =>
        new MinimumCostOfBuyingCandiesWithDiscount().MinimumCost( cost );
}
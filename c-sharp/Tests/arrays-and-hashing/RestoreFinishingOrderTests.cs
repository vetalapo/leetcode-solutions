using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;
public class RestoreFinishingOrderTests
{
    [TestCase( new int[] { 3, 1, 2, 5, 4 }, new int[] { 1, 3, 4 }, ExpectedResult = new int[] { 3, 1, 4 } )]
    [TestCase( new int[] { 1, 4, 5, 3, 2 }, new int[] { 2, 5 }, ExpectedResult = new int[] { 5, 2 } )]
    [TestCase( new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 }, ExpectedResult = new int[] { 2, 3, 4 } )]
    public int[] RecoverOrderTest( int[] order, int[] friends ) =>
        new RestoreFinishingOrder().RecoverOrder( order, friends );
}

using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class FindThePeaksTests
{
    [TestCase( new int[] { 2, 4, 4 }, ExpectedResult = new int[] { } )]
    [TestCase( new int[] { 1, 4, 3, 8, 5 }, ExpectedResult = new int[] { 1, 3 } )]
    public IList<int> FindPeaksTest( int[] mountain ) =>
        new FindThePeaks().FindPeaks( mountain );
}

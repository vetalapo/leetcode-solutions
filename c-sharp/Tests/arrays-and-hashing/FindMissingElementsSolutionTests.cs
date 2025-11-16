using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindMissingElementsSolutionTests
{
    [TestCase( new int[] { 1, 4, 2, 5 }, ExpectedResult = new int[] { 3 } )]
    [TestCase( new int[] { 7, 8, 6, 9 }, ExpectedResult = new int[] { } )]
    [TestCase( new int[] { 5, 1 }, ExpectedResult = new int[] { 2, 3, 4 } )]
    public IList<int> FindMissingElementsTest( int[] nums ) =>
        new FindMissingElementsSolution().FindMissingElements( nums );
}

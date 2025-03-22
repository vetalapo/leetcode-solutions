using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class SelfDividingNumbersSolutionTests
{
    [TestCase( 1, 22, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 } )]
    [TestCase( 47, 85, ExpectedResult = new int[] { 48, 55, 66, 77 } )]
    public IList<int> SelfDividingNumbersTest( int left, int right ) =>
        new SelfDividingNumbersSolution().SelfDividingNumbers( left, right );
}

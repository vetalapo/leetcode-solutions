using System.Collections.Generic;

using NUnit.Framework;

namespace Problems.Tests;

public class AddToArrayFormOfIntegerTests
{
    [TestCase( new int[] { 1, 2, 0, 0 }, 34, ExpectedResult = new int[] { 1, 2, 3, 4 } )]
    [TestCase( new int[] { 2, 7, 4 }, 181, ExpectedResult = new int[] { 4, 5, 5 } )]
    [TestCase( new int[] { 2, 1, 5 }, 806, ExpectedResult = new int[] { 1, 0, 2, 1 } )]
    [TestCase( new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1, ExpectedResult = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } )]
    public IList<int> AddToArrayFormTest( int[] num, int k ) =>
        new AddToArrayFormOfInteger().AddToArrayForm( num, k );
}

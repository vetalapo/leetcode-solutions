using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class BinaryPrefixDivisibleBy5Tests
{
    [TestCase( new int[] { 0, 1, 1 }, ExpectedResult = new bool[] { true, false, false } )]
    [TestCase( new int[] { 1, 1, 1 }, ExpectedResult = new bool[] { false, false, false } )]
    public IList<bool> PrefixesDivBy5Test( int[] nums ) =>
        new BinaryPrefixDivisibleBy5().PrefixesDivBy5( nums );
}

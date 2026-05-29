using NUnit.Framework;

using Problems;

namespace Mathematics;

public class MinimumElementAfterReplacementWithDigitSumTests
{
    [TestCase( new int[] { 10, 12, 13, 14 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 999, 19, 199 }, ExpectedResult = 10 )]
    public int MinElementTest( int[] nums ) =>
        new MinimumElementAfterReplacementWithDigitSum().MinElement( nums );
}
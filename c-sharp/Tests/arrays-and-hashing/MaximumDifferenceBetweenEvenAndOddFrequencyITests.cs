using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumDifferenceBetweenEvenAndOddFrequencyITests
{
    [TestCase( "aaaaabbc", ExpectedResult = 3 )]
    [TestCase( "abcabcab", ExpectedResult = 1 )]
    [TestCase( "mmsmsym", ExpectedResult = -1 )]
    public int MaxDifferenceTest( string s ) =>
        new MaximumDifferenceBetweenEvenAndOddFrequencyI().MaxDifference( s );
}
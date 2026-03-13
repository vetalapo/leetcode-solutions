using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindMostFrequentVowelAndConsonantTests
{
    [TestCase( "successes", ExpectedResult = 6 )]
    [TestCase( "aeiaeia", ExpectedResult = 3 )]
    [TestCase( "cz", ExpectedResult = 1 )]
    public int MaxFreqSumTest( string s ) =>
        new FindMostFrequentVowelAndConsonant().MaxFreqSum( s );
}

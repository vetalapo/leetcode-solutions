using NUnit.Framework;
using Problems;

namespace Mathematics;

public class DigitFrequencyScoreTests
{
    [TestCase( 122, ExpectedResult = 5 )]
    [TestCase( 101, ExpectedResult = 2 )]
    public int DigitFrequencyScoreTest( int n ) =>
        new DigitFrequencyScoreSolution().DigitFrequencyScore( n );
}
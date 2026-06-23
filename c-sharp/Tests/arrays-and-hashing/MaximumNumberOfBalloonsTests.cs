using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumNumberOfBalloonsTests
{
    [TestCase( "nlaebolko", ExpectedResult = 1 )]
    [TestCase( "loonbalxballpoon", ExpectedResult = 2 )]
    [TestCase( "leetcode", ExpectedResult = 0 )]
    public int MaxNumberOfBalloonsTest( string text ) =>
        new MaximumNumberOfBalloons().MaxNumberOfBalloons( text );
}
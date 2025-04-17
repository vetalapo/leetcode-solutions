using NUnit.Framework;

using Problems;

public class SecondLargestDigitInAStringTests
{
    [TestCase( "dfa12321afd", ExpectedResult = 2 )]
    [TestCase( "abc1111", ExpectedResult = -1 )]
    [TestCase( "sjhtz8344", ExpectedResult = 4 )]
    public int SecondHighestTest( string s ) =>
        new SecondLargestDigitInAString().SecondHighest( s );
}

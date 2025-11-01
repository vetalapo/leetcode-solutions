using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class ConsecutiveCharactersTests
{
    [TestCase( "leetcode", ExpectedResult = 2 )]
    [TestCase( "abbcccddddeeeeedcba", ExpectedResult = 5 )]
    [TestCase( "hooraaaaaaaaaaay", ExpectedResult = 11 )]
    public int MaxPowerTest( string s ) =>
        new ConsecutiveCharacters().MaxPower( s );
}

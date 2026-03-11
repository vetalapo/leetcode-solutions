using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class LargestSubstringBetweenTwoEqualCharactersTests
{
    [TestCase( "aa", ExpectedResult = 0 )]
    [TestCase( "abca", ExpectedResult = 2 )]
    [TestCase( "cbzxy", ExpectedResult = -1 )]
    [TestCase( "mgntdygtxrvxjnwksqhxuxtrv", ExpectedResult = 18 )]
    public int MaxLengthBetweenEqualCharactersTest( string s ) =>
        new LargestSubstringBetweenTwoEqualCharacters().MaxLengthBetweenEqualCharacters( s );
}

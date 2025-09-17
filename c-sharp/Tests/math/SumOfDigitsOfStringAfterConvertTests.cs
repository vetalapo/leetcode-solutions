using NUnit.Framework;

using Problems;

public class SumOfDigitsOfStringAfterConvertTests
{
    [TestCase( "iiii", 1, ExpectedResult = 36 )]
    [TestCase( "leetcode", 2, ExpectedResult = 6 )]
    [TestCase( "zbax", 2, ExpectedResult = 8 )]
    public int GetLuckyTest( string s, int k ) =>
        new SumOfDigitsOfStringAfterConvert().GetLucky( s, k );
}

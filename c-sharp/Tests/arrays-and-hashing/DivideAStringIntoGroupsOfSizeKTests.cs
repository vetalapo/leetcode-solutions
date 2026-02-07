using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DivideAStringIntoGroupsOfSizeKTests
{
    [TestCase( "abcdefghi", 3, 'x', ExpectedResult = new string[] { "abc", "def", "ghi" } )]
    [TestCase( "abcdefghij", 3, 'x', ExpectedResult = new string[] { "abc", "def", "ghi", "jxx" } )]
    public string[] DivideStringTest( string s, int k, char fill ) =>
        new DivideAStringIntoGroupsOfSizeK().DivideString( s, k, fill );
}

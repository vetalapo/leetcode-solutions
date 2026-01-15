using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FirstUniqueCharacterInAStringTests
{
    [TestCase( "leetcode", ExpectedResult = 0 )]
    [TestCase( "loveleetcode", ExpectedResult = 2 )]
    [TestCase( "aabb", ExpectedResult = -1 )]
    public int FirstUniqCharTest( string s ) =>
        new FirstUniqueCharacterInAString().FirstUniqChar( s );
}

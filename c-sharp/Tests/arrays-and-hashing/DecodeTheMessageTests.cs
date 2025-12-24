using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DecodeTheMessageTests
{
    [TestCase( "the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv", ExpectedResult = "this is a secret" )]
    [TestCase( "eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb", ExpectedResult = "the five boxing wizards jump quickly" )]
    public string DecodeMessageTest( string key, string message ) =>
        new DecodeTheMessage().DecodeMessage( key, message );
}

using NUnit.Framework;

using Problems;

public class SlowestKeySolutionTests
{
    [TestCase( new int[] { 9, 29, 49, 50 }, "cbcd", ExpectedResult = 'c' )]
    [TestCase( new int[] { 12, 23, 36, 46, 62 }, "spuda", ExpectedResult = 'a' )]
    public char SlowestKeyTest( int[] releaseTimes, string keysPressed ) =>
        new SlowestKeySolution().SlowestKey( releaseTimes, keysPressed );
}

using NUnit.Framework;

using Problems;

namespace Greedy;

public class OneBitAndTwoBitCharactersTests
{
    [TestCase( new int[] { 1, 0, 0 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 1, 1, 0 }, ExpectedResult = false )]
    public bool IsOneBitCharacterTest( int[] bits ) =>
        new OneBitAndTwoBitCharacters().IsOneBitCharacter( bits );
}

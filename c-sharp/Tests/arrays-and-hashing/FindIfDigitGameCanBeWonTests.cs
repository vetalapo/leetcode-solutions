using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindIfDigitGameCanBeWonTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 10 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 2, 3, 4, 5, 14 }, ExpectedResult = true )]
    [TestCase( new int[] { 5, 5, 5, 25 }, ExpectedResult = true )]
    public bool CanAliceWinTest( int[] nums ) =>
        new FindIfDigitGameCanBeWon().CanAliceWin( nums );
}

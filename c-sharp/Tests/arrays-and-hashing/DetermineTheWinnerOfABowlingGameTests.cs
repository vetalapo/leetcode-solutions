using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class DetermineTheWinnerOfABowlingGameTests
{
    [TestCase( new int[] { 5, 10, 3, 2 }, new int[] { 6, 5, 7, 3 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 3, 5, 7, 6 }, new int[] { 8, 10, 10, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 2, 3 }, new int[] { 4, 1 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 1, 1, 10, 10, 10, 10 }, new int[] { 10, 10, 10, 10, 1, 1, 1 }, ExpectedResult = 2 )]
    public int IsWinnerTest( int[] player1, int[] player2 ) =>
        new DetermineTheWinnerOfABowlingGame().IsWinner( player1, player2 );
}

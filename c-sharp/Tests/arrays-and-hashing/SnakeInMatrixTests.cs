using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class SnakeInMatrixTests
{
    [TestCase( 2, new string[] { "RIGHT", "DOWN" }, ExpectedResult = 3 )]
    [TestCase( 3, new string[] { "DOWN", "RIGHT", "UP" }, ExpectedResult = 1 )]
    public int FinalPositionOfSnakeTest( int n, IList<string> commands ) =>
        new SnakeInMatrix().FinalPositionOfSnake( n, commands );
}

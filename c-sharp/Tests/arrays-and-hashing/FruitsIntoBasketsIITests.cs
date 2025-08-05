using NUnit.Framework;

using Problems;

public class FruitsIntoBasketsIITests
{
    [TestCase( new int[] { 4, 2, 5 }, new int[] { 3, 5, 4 }, ExpectedResult = 1 )]
    [TestCase( new int[] { 3, 6, 1 }, new int[] { 6, 4, 7 }, ExpectedResult = 0 )]
    public int NumOfUnplacedFruitsTest( int[] fruits, int[] baskets ) =>
        new FruitsIntoBasketsII().NumOfUnplacedFruits( fruits, baskets );
}

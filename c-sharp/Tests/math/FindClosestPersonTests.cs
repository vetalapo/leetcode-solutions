using NUnit.Framework;

using Problems;

public class FindClosestPersonTests
{
    [TestCase( 2, 7, 4, ExpectedResult = 1 )]
    [TestCase( 2, 5, 6, ExpectedResult = 2 )]
    [TestCase( 1, 5, 3, ExpectedResult = 0 )]
    public int FindClosestTest( int x, int y, int z ) =>
        new FindClosestPerson().FindClosest( x, y, z );
}

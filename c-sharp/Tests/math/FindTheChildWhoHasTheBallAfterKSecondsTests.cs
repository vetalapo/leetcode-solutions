using NUnit.Framework;

using Problems;

public class FindTheChildWhoHasTheBallAfterKSecondsTests
{
    [TestCase( 3, 5, ExpectedResult = 1 )]
    [TestCase( 5, 6, ExpectedResult = 2 )]
    [TestCase( 4, 2, ExpectedResult = 2 )]
    public int NumberOfChildTest( int n, int time ) =>
        new FindTheChildWhoHasTheBallAfterKSeconds().NumberOfChild( n, time );
}

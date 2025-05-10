using NUnit.Framework;

using Problems;

public class DistributeMoneyToMaximumChildrenTests
{
    [TestCase( 20, 3, ExpectedResult = 1 )]
    [TestCase( 16, 2, ExpectedResult = 2 )]
    [TestCase( 1, 2, ExpectedResult = -1 )]
    [TestCase( 12, 3, ExpectedResult = 1 )]
    [TestCase( 9, 2, ExpectedResult = 1 )]
    public int DistMoneyTest( int money, int children ) =>
        new DistributeMoneyToMaximumChildren().DistMoney( money, children );
}

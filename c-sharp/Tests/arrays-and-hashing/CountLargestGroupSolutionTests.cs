using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountLargestGroupSolutionTests
{
    [TestCase( 13, ExpectedResult = 4 )]
    [TestCase( 2, ExpectedResult = 2 )]
    [TestCase( 24, ExpectedResult = 5 )]
    [TestCase( 9685, ExpectedResult = 1 )]
    [TestCase( 9999, ExpectedResult = 1 )]
    public int CountLargestGroupTest( int n ) =>
        new CountLargestGroupSolution().CountLargestGroup( n );
}

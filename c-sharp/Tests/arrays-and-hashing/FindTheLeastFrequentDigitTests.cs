using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class FindTheLeastFrequentDigitTests
{
    [TestCase( 1553322, ExpectedResult = 1 )]
    [TestCase( 723344511, ExpectedResult = 2 )]
    public int GetLeastFrequentDigitTest( int n ) =>
        new FindTheLeastFrequentDigit().GetLeastFrequentDigit( n );
}

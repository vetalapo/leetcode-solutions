using NUnit.Framework;

using Problems;

namespace SlidingWindow;

public class FindTheKBeautyOfANumberTests
{
    [TestCase( 240, 2, ExpectedResult = 2 )]
    [TestCase( 430043, 2, ExpectedResult = 2 )]
    [TestCase( 10, 2, ExpectedResult = 1 )]
    [TestCase( 2, 1, ExpectedResult = 1 )]
    public int DivisorSubstringsTest( int num, int k ) =>
        new FindTheKBeautyOfANumber().DivisorSubstrings( num, k );
}

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountGoodTripletsSolutionTests
{
    [TestCase( new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 1, 2, 2, 3 }, 0, 0, 1, ExpectedResult = 0 )]
    public int CountGoodTripletsTest( int[] arr, int a, int b, int c ) =>
        new CountGoodTripletsSolution().CountGoodTriplets( arr, a, b, c );
}

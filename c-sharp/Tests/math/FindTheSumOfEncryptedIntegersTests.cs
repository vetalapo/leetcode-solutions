using NUnit.Framework;

using Problems;

public class FindTheSumOfEncryptedIntegersTests
{
    [TestCase( new int[] { 1, 2, 3 }, ExpectedResult = 6 )]
    [TestCase( new int[] { 10, 21, 31 }, ExpectedResult = 66 )]
    public int SumOfEncryptedIntTest( int[] nums ) =>
        new FindTheSumOfEncryptedIntegers().SumOfEncryptedInt( nums );
}

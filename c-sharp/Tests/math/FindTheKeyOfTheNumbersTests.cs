using NUnit.Framework;

using Problems;

public class FindTheKeyOfTheNumbersTests
{
    [TestCase( 1, 10, 1000, ExpectedResult = 0 )]
    [TestCase( 987, 879, 798, ExpectedResult = 777 )]
    [TestCase( 1, 2, 3, ExpectedResult = 1 )]
    [TestCase( 282, 718, 1028, ExpectedResult = 12 )]
    public int GenerateKeyTest( int num1, int num2, int num3 ) =>
        new FindTheKeyOfTheNumbers().GenerateKey( num1, num2, num3 );
}

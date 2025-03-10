using NUnit.Framework;

using Problems;

public class LargestOddNumberInStringTests
{
    [TestCase( "52", ExpectedResult = "5" )]
    [TestCase( "4206", ExpectedResult = "" )]
    [TestCase( "35427", ExpectedResult = "35427" )]
    [TestCase( "10133890", ExpectedResult = "1013389" )]
    [TestCase( "486379402", ExpectedResult = "486379" )]
    public string LargestOddNumberTest( string num ) =>
        new LargestOddNumberInString().LargestOddNumber( num );
}

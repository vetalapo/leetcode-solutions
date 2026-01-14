using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class LargestEvenNumberTests
{
    [TestCase( "1112", ExpectedResult = "1112" )]
    [TestCase( "221", ExpectedResult = "22" )]
    [TestCase( "1", ExpectedResult = "" )]
    public string LargestEvenTest( string s ) =>
        new LargestEvenNumber().LargestEven( s );
}

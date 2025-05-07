using NUnit.Framework;

using Problems;

public class DetectCapitalTests
{
    [TestCase( "USA", ExpectedResult = true )]
    [TestCase( "FlaG", ExpectedResult = false )]
    public bool DetectCapitalUseTest( string word ) =>
        new DetectCapital().DetectCapitalUse( word );
}

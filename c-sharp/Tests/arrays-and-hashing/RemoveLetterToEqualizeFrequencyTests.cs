using NUnit.Framework;

using Problems;

public class RemoveLetterToEqualizeFrequencyTests
{
    [TestCase( "abcc", ExpectedResult = true )]
    [TestCase( "aazz", ExpectedResult = false )]
    [TestCase( "bac", ExpectedResult = true )]
    [TestCase( "adbc", ExpectedResult = true )]
    [TestCase( "aca", ExpectedResult = true )]
    [TestCase( "ddaccb", ExpectedResult = false )]
    [TestCase( "acbda", ExpectedResult = true )]
    [TestCase( "abbcc", ExpectedResult = true )]
    public bool EqualFrequencyTest( string word ) =>
        new RemoveLetterToEqualizeFrequency().EqualFrequency( word );
}

using NUnit.Framework;

using Problems;

public class DecryptStringFromAlphabetToIntegerMappingTests
{
    [TestCase( "10#11#12", ExpectedResult = "jkab" )]
    [TestCase( "1326#", ExpectedResult = "acz" )]
    public string FreqAlphabetsTest( string s ) =>
        new DecryptStringFromAlphabetToIntegerMapping().FreqAlphabets( s );
}

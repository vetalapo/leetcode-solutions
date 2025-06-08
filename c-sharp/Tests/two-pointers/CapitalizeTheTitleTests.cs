using NUnit.Framework;

using Problems;

public class CapitalizeTheTitleTests
{
    [TestCase( "capiTalIze tHe titLe", ExpectedResult = "Capitalize The Title" )]
    [TestCase( "First leTTeR of EACH Word", ExpectedResult = "First Letter of Each Word" )]
    [TestCase( "i lOve leetcode", ExpectedResult = "i Love Leetcode" )]
    [TestCase( "L hV", ExpectedResult = "l hv" )]
    [TestCase( "ZW Cl pyR uoC", ExpectedResult = "zw cl Pyr Uoc" )]
    public string CapitalizeTitleTest( string title ) =>
        new CapitalizeTheTitle().CapitalizeTitle( title );
}

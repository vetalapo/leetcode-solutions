using NUnit.Framework;

using Problems;

public class StrongPasswordCheckerIISolutionTests
{
    [TestCase( "IloveLe3tcode!", ExpectedResult = true )]
    [TestCase( "Me+You--IsMyDream", ExpectedResult = false )]
    [TestCase( "1aB!", ExpectedResult = false )]
    public bool StrongPasswordCheckerIITest( string password ) =>
        new StrongPasswordCheckerIISolution().StrongPasswordCheckerII( password );
}

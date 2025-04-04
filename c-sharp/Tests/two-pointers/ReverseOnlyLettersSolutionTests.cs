using NUnit.Framework;

using Problems;

public class ReverseOnlyLettersSolutionTests
{
    [TestCase( "ab-cd", ExpectedResult = "dc-ba" )]
    [TestCase( "a-bC-dEf-ghIj", ExpectedResult = "j-Ih-gfE-dCba" )]
    [TestCase( "Test1ng-Leet=code-Q!", ExpectedResult = "Qedo1ct-eeLg=ntse-T!" )]
    public string ReverseOnlyLettersTest( string s ) =>
        new ReverseOnlyLettersSolution().ReverseOnlyLetters( s );
}

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class RemoveOutermostParenthesesTests
{
    [TestCase( "(()())(())", ExpectedResult = "()()()" )]
    [TestCase( "(()())(())(()(()))", ExpectedResult = "()()()()(())" )]
    [TestCase( "()()", ExpectedResult = "" )]
    public string RemoveOuterParenthesesTest( string s ) =>
        new RemoveOutermostParentheses().RemoveOuterParentheses( s );
}

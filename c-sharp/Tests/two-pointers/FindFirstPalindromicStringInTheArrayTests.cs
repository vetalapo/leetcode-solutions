using NUnit.Framework;

using Problems;

public class FindFirstPalindromicStringInTheArrayTests
{
    [TestCase( [new string[] { "abc", "car", "ada", "racecar", "cool" }], ExpectedResult = "ada" )]
    [TestCase( [new string[] { "notapalindrome", "racecar" }], ExpectedResult = "racecar" )]
    [TestCase( [new string[] { "def", "ghi" }], ExpectedResult = "" )]
    public string FirstPalindromeTest( string[] words ) =>
        new FindFirstPalindromicStringInTheArray().FirstPalindrome( words );
}

using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CheckIfAStringIsAnAcronymOfWordsTests
{
    [TestCase( new string[] { "alice", "bob", "charlie" }, "abc", ExpectedResult = true )]
    [TestCase( new string[] { "an", "apple" }, "a", ExpectedResult = false )]
    [TestCase( new string[] { "never", "gonna", "give", "up", "on", "you" }, "ngguoy", ExpectedResult = true )]
    public bool IsAcronymTest( IList<string> words, string s ) =>
        new CheckIfAStringIsAnAcronymOfWords().IsAcronym( words, s );
}

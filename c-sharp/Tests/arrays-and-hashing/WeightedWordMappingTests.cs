using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class WeightedWordMappingTests
{
    [TestCase(
        new string[] { "abcd", "def", "xyz" },
        new int[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 },
        ExpectedResult = "rij"
    )]
    
    [TestCase(
        new string[] { "a", "b", "c" },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        ExpectedResult = "yyy"
    )]
    
    [TestCase(
        new string[] { "abcd" },
        new int[] { 7, 5, 3, 4, 3, 5, 4, 9, 4, 2, 2, 7, 10, 2, 5, 10, 6, 1, 2, 2, 4, 1, 3, 4, 4, 5 },
        ExpectedResult = "g"
    )]
    public string MapWordWeightsTest( string[] words, int[] weights ) =>
        new WeightedWordMapping().MapWordWeights( words, weights );
}

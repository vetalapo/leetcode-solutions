using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class MaximumValueOfAStringInAnArrayTests
{
    [TestCase( [new string[] { "alic3", "bob", "3", "4", "00000" }], ExpectedResult = 5 )]
    [TestCase( [new string[] { "1", "01", "001", "0001" }], ExpectedResult = 1 )]
    public int MaximumValueTest( string[] strs ) =>
        new MaximumValueOfAStringInAnArray().MaximumValue( strs );
}
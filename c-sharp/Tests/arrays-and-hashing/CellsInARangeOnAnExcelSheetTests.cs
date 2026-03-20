using System.Collections.Generic;
using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CellsInARangeOnAnExcelSheetTests
{
    [TestCase( "K1:L2", ExpectedResult = new string[] { "K1","K2","L1","L2" } )]
    [TestCase( "A1:F1", ExpectedResult = new string[] { "A1","B1","C1","D1","E1","F1" } )]
    public IList<string> CellsInRangeTest( string s ) =>
        new CellsInARangeOnAnExcelSheet().CellsInRange( s );
}

using NUnit.Framework;

using Problems;

public class StudentAttendanceRecordITests
{
    [TestCase( "PPALLP", ExpectedResult = true )]
    [TestCase( "PPALLL", ExpectedResult = false )]
    [TestCase( "AA", ExpectedResult = false )]
    public bool CheckRecordTest( string s ) =>
        new StudentAttendanceRecordI().CheckRecord( s );
}

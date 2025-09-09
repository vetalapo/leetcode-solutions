using NUnit.Framework;

using Problems;

public class CountTestedDevicesAfterTestOperationsTests
{
    [TestCase( new int[] { 1, 1, 2, 1, 3 }, ExpectedResult = 3 )]
    [TestCase( new int[] { 0, 1, 2 }, ExpectedResult = 2 )]
    public int CountTestedDevicesTest( int[] batteryPercentages ) =>
        new CountTestedDevicesAfterTestOperations().CountTestedDevices( batteryPercentages );
}

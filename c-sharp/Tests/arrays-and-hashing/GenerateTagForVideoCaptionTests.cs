using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class GenerateTagForVideoCaptionTests
{
    [TestCase( "Leetcode daily streak achieved", ExpectedResult = "#leetcodeDailyStreakAchieved" )]
    [TestCase( "can I Go There", ExpectedResult = "#canIGoThere" )]
    [TestCase( "hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh", ExpectedResult = "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh" )]
    [TestCase( "   ", ExpectedResult = "#" )]
    [TestCase( " fPysaRtLQLiMKVvRhMkkDLNedQKffPnCjbITBTOVhoVjiKbfSawvpisDaNzXJctQkn", ExpectedResult = "#fpysartlqlimkvvrhmkkdlnedqkffpncjbitbtovhovjikbfsawvpisdanzxjctqkn" )]
    public string GenerateTagTest( string caption ) =>
        new GenerateTagForVideoCaption().GenerateTag( caption );
}

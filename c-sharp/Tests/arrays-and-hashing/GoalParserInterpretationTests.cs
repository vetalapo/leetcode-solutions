using NUnit.Framework;

using Problems;

public class GoalParserInterpretationTests
{
    [TestCase( "G()(al)", ExpectedResult = "Goal" )]
    [TestCase( "G()()()()(al)", ExpectedResult = "Gooooal" )]
    [TestCase( "(al)G(al)()()G", ExpectedResult = "alGalooG" )]
    public string InterpretTest( string command ) =>
        new GoalParserInterpretation().Interpret( command );
}

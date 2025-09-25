using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CountItemsMatchingARuleTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int CountMatchesTest( IList<IList<string>> items, string ruleKey, string ruleValue ) =>
        new CountItemsMatchingARule().CountMatches( items, ruleKey, ruleValue );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(
                new string[][] { ["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"] },
                "color",
                "silver"
            ).Returns( 1 );

            yield return new TestCaseData(
                new string[][] { ["phone", "blue", "pixel"], ["computer", "silver", "phone"], ["phone", "gold", "iphone"] },
                "type",
                "phone"
            ).Returns( 2 );
        }
    }
}

using System.Collections.Generic;

using NUnit.Framework;

using Problems;

namespace ArraysAndHashing;

public class CouponCodeValidatorTests
{
    [TestCase(
        new string[] { "SAVE20", "", "PHARMA5", "SAVE@20" },
        new string[] { "restaurant", "grocery", "pharmacy", "restaurant" },
        new bool[] { true, true, true, true },
        ExpectedResult = new string[] { "PHARMA5", "SAVE20" }
    )]

    [TestCase(
        new string[] { "GROCERY15", "ELECTRONICS_50", "DISCOUNT10" },
        new string[] { "grocery", "electronics", "invalid" },
        new bool[] { false, true, true },
        ExpectedResult = new string[] { "ELECTRONICS_50" }
    )]

    [TestCase(
        new string[] { "1OFw", "0MvB" },
        new string[] { "electronics", "pharmacy" },
        new bool[] { true, true },
        ExpectedResult = new string[] { "1OFw", "0MvB" }
    )]

    [TestCase(
        new string[] { "MI", "b_" },
        new string[] { "pharmacy", "pharmacy" },
        new bool[] { true, true },
        ExpectedResult = new string[] { "MI", "b_" }
    )]

    [TestCase(
        new string[] { "Qf8NjqOTYp", "w4xOTEM20C" },
        new string[] { "pharmacy", "pharmacy" },
        new bool[] { true, true },
        ExpectedResult = new string[] { "Qf8NjqOTYp", "w4xOTEM20C" }
    )]

    [TestCase(
        new string[] { "yaagHitF6", "Nr15urtUA", "aCYzLXjbw" },
        new string[] { "electronics", "electronics", "grocery" },
        new bool[] { true, false, true },
        ExpectedResult = new string[] { "yaagHitF6", "aCYzLXjbw" }
    )]
    public IList<string> ValidateCouponsTest( string[] code, string[] businessLine, bool[] isActive ) =>
        new CouponCodeValidator().ValidateCoupons( code, businessLine, isActive );
}

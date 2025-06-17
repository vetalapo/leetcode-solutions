/**
 * 2299
 * Strong Password Checker II
 **
 * A password is said to be strong if it satisfies all the following criteria:
 *   • It has at least 8 characters.
 *   • It contains at least one lowercase letter.
 *   • It contains at least one uppercase letter.
 *   • It contains at least one digit.
 *   • It contains at least one special character.
 *     The special characters are the characters in the following string: "!@#$%^&*()-+".
 *   • It does not contain 2 of the same character in adjacent positions
 *     (i.e., "aab" violates this condition, but "aba" does not).
 *
 * Given a string password,
 * return true if it is a strong password.
 * Otherwise, return false.
 *
 * Example 1:
 *   Input: password = "IloveLe3tcode!"
 *   Output: true
 *   Explanation:
 *     The password meets all the requirements.
 *     Therefore, we return true.
 *
 * Example 2:
 *   Input: password = "Me+You--IsMyDream"
 *   Output: false
 *   Explanation:
 *     The password does not contain a digit
 *     and also contains 2 of the same character in adjacent positions.
 *     Therefore, we return false.
 *
 * Example 3:
 *   Input: password = "1aB!"
 *   Output: false
 *   Explanation:
 *     The password does not meet the length requirement.
 *     Therefore, we return false.
 *
 * Constraints:
 *   • 1 <= password.length <= 100
 *   • password consists of letters, digits, and special characters: "!@#$%^&*()-+".
 *
 * Hint 1:
 *   You can use a boolean flag to define certain types of characters seen in the string.
 *
 * Hint 2:
 *   In the end, check if all boolean flags have ended up True,
 *   and do not forget to check the "adjacent" and "length" criteria.
 **
 * https://leetcode.com/problems/strong-password-checker-ii/
***/

using System;

namespace Problems;

public class StrongPasswordCheckerIISolution
{
    private static readonly string specialSymbols = "!@#$%^&*()-+";

    public bool StrongPasswordCheckerII( string password )
    {
        if ( password.Length < 8 )
        {
            return false;
        }

        bool containsLowerCase = false;
        bool containsUpperCase = false;
        bool containsDigit = false;
        bool containsSpecial = false;

        for ( int i = 0; i < password.Length; i++ )
        {
            if ( i + 1 < password.Length && password[i] == password[i + 1] )
            {
                return false;
            }

            if ( !containsLowerCase && Char.IsLower( password[i] ) )
            {
                containsLowerCase = true;
            }

            if ( !containsUpperCase && Char.IsUpper( password[i] ) )
            {
                containsUpperCase = true;
            }

            if ( !containsDigit && Char.IsDigit( password[i] ) )
            {
                containsDigit = true;
            }

            if ( !containsSpecial && specialSymbols.Contains( password[i] ) )
            {
                containsSpecial = true;
            }
        }

        return containsLowerCase &&
            containsUpperCase &&
            containsDigit &&
            containsSpecial;
    }
}

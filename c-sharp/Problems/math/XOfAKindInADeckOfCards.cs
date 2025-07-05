/**
 * 914
 * X of a Kind in a Deck of Cards
 **
 * You are given an integer array deck
 * where deck[i] represents the number written on the ith card.
 *
 * Partition the cards into one or more groups such that:
 *   • Each group has exactly x cards where x > 1, and
 *   • All the cards in one group have the same integer written on them.
 *
 * Return true if such partition is possible, or false otherwise.
 *
 * Example 1:
 *   Input: deck = [1,2,3,4,4,3,2,1]
 *   Output: true
 *   Explanation: Possible partition [1,1],[2,2],[3,3],[4,4].
 *
 * Example 2:
 *   Input: deck = [1,1,1,2,2,2,3,3]
 *   Output: false
 *   Explanation: No possible partition.
 *
 * Constraints:
 *   • 1 <= deck.length <= 10^4
 *   • 0 <= deck[i] < 10^4
 **
 * https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/
***/

namespace Problems;

public class XOfAKindInADeckOfCards
{
    public bool HasGroupsSizeX( int[] deck )
    {
        int[] countMap = new int[10000];

        foreach ( int card in deck )
        {
            countMap[card]++;
        }

        int groups = 0;

        foreach ( int val in countMap )
        {
            if ( val > 0 )
            {
                groups = GCD( groups, val );

                if ( groups == 1 )
                {
                    return false;
                }
            }
        }

        return groups > 1;
    }

    private int GCD( int a, int b )
    {
        if ( b == 0 )
        {
            return a;
        }

        return GCD( b, a % b );
    }
}

﻿/**
 * 948
 * Bag of Tokens
 **
 * You start with an initial power of power,
 * an initial score of 0,
 * and a bag of tokens given as an integer array tokens,
 * where each tokens[i] donates the value of token[i].
 *
 * Your goal is to maximize the total score by strategically playing these tokens.
 *
 * In one move, you can play an un-played token in one of the two ways (but not both for the same token):
 *   • Face-up: If your current power is at least tokens[i], you may play token[i], losing tokens[i] power and gaining 1 score.
 *   • Face-down: If your current score is at least 1, you may play token[i], gaining tokens[i] power and losing 1 score.
 *
 * Return the maximum possible score you can achieve after playing any number of tokens.
 *
 * Example 1:
 *   Input: tokens = [100], power = 50
 *   Output: 0
 *   Explanation:
 *     Since your score is 0 initially, you cannot play the token face-down.
 *     You also cannot play it face-up since your power (50) is less than tokens[0] (100).
 *
 * Example 2:
 *   Input: tokens = [200,100], power = 150
 *   Output: 1
 *   Explanation:
 *     Play token1 (100) face-up, reducing your power to 50 and increasing your score to 1.
 *     There is no need to play token0, since you cannot play it face-up to add to your score. The maximum score achievable is 1.
 *
 * Example 3:
 *   Input: tokens = [100,200,300,400], power = 200
 *   Output: 2
 *   Explanation:
 *   Play the tokens in this order to get a score of 2:
 *     1. Play token0 (100) face-up, reducing power to 100 and increasing score to 1.
 *     2. Play token3 (400) face-down, increasing power to 500 and reducing score to 0.
 *     3. Play token1 (200) face-up, reducing power to 300 and increasing score to 1.
 *     4. Play token2 (300) face-up, reducing power to 0 and increasing score to 2.
 *
 *   The maximum score achievable is 2.
 *
 * Constraints:
 *   • 0 <= tokens.length <= 1000
 *   • 0 <= tokens[i], power < 10^4
 **
 * https://leetcode.com/problems/bag-of-tokens/
***/

using System;

namespace Problems;

public class BagOfTokens
{
    public int BagOfTokensScore( int[] tokens, int power )
    {
        int maxScore = 0;
        int score = 0;

        Array.Sort( tokens );

        int left = 0;
        int right = tokens.Length - 1;

        while ( left <= right )
        {
            if ( power >= tokens[left] )
            {
                power -= tokens[left];
                left++;
                score++;
                maxScore = Math.Max( maxScore, score );
            }
            else if ( score > 0 )
            {
                power += tokens[right];
                right--;
                score--;
            }
            else
            {
                break;
            }
        }

        return maxScore;
    }
}

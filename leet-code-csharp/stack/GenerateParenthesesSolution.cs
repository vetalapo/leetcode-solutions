﻿namespace leet_code_csharp.stack;

public class GenerateParenthesesSolution
{
    public IList<string> GenerateParenthesis( int n )
    {
        List<string> result = new();
        Stack<string> stack = new();

        void backtrack( int openP, int closedP )
        {
            if ( n == closedP && openP == closedP )
            {
                result.Add( string.Join( "", stack.ToArray().Reverse() ) );

                return;
            }

            if ( openP < n )
            {
                stack.Push( "(" );

                backtrack( openP + 1, closedP );

                stack.Pop();
            }

            if ( closedP < openP )
            {
                stack.Push( ")" );

                backtrack( openP, closedP + 1 );

                stack.Pop();
            }
        }

        backtrack( 0, 0 );

        return result;
    }
}

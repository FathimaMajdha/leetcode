using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        if (n == 0) return new List<string> { "" };

        List<string> result = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var leftList = GenerateParenthesis(i);
            var rightList = GenerateParenthesis(n - 1 - i);

            foreach (var left in leftList)
            {
                foreach (var right in rightList)
                {
                    result.Add("(" + left + ")" + right);
                }
            }
        }

        return result;
    }
}

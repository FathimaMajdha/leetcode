using System;

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s; 

        string[] ans = new string[numRows]; // Initialize array
        for (int j = 0; j < numRows; j++) {
            ans[j] = "";
        }

        int i = 0;
        while (i < s.Length) {
            // Vertical down
            for (int index = 0; index < numRows && i < s.Length; index++) {
                ans[index] += s[i++];
            }

            // Diagonal up
            for (int index = numRows - 2; index > 0 && i < s.Length; index--) {
                ans[index] += s[i++];
            }
        }

        string res = "";
        foreach (string str in ans) {
            res += str;
        }

        return res;
    }
}

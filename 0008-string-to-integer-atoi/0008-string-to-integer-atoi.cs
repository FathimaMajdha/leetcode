using System;

public class Solution {
    public int MyAtoi(string s) {
        int i = 0, sign = 1, result = 0;
    
        while (i < s.Length && s[i] == ' ') i++;

        if (i < s.Length && (s[i] == '+' || s[i] == '-')) {
            sign = s[i++] == '-' ? -1 : 1;
        }

        while (i < s.Length && Char.IsDigit(s[i])) {
            int digit = s[i++] - '0';

            if (result > (int.MaxValue - digit) / 10)
                return sign == 1 ? int.MaxValue : int.MinValue;

            result = result * 10 + digit;
        }

        return result * sign;
    }
}


public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        for (int i = 0; i < s.Length; i++) {
            int curr = GetValue(s[i]);
            int next = (i < s.Length - 1) ? GetValue(s[i + 1]) : 0;
            
            total += (curr < next) ? -curr : curr;
        }
        return total;
    }

    private int GetValue(char c) {
        return c == 'I' ? 1 : c == 'V' ? 5 : c == 'X' ? 10 :
               c == 'L' ? 50 : c == 'C' ? 100 : c == 'D' ? 500 : 1000;
    }
}

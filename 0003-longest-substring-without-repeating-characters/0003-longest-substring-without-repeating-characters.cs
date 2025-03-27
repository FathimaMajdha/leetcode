public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();

        int maxLength=0;
        int left=0;


        for(int right=0;right<s.Length;right++){
            while(charSet.Contains(s[right])){
                charSet.Remove(s[left]);
                left++;
            }

            charSet.Add(s[right]);
            maxLength=Math.Max(maxLength,right-left+1);
        }
        return maxLength;
    }
}
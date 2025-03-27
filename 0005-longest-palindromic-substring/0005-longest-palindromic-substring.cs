public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length<=1){
            return s;
        }

        string LPS = ""; 

        for(int i=1;i<s.Length;i++){
            int low=i;
            int high=i;

            while(low >= 0 && high < s.Length && s[low]==s[high] ){
                low--;
                high++;

            }

            string palindrome=s.Substring(low+1,high-low-1);
            if(palindrome.Length > LPS.Length){
                LPS=palindrome;
            }

            low=i-1;
            high=i;

            while(low >= 0 && high < s.Length && s[low]==s[high]){
                low--;
                high++;

            }
            palindrome=s.Substring(low+1,high-low-1);
            if(palindrome.Length > LPS.Length){
                LPS=palindrome;
            }

        }
        return LPS;
    }
}
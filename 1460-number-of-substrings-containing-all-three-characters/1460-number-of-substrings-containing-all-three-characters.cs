using System;

public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] lastSeen = { -1, -1, -1 }; 
        int count = 0;
        
        for (int r = 0; r < s.Length; r++) {
            lastSeen[s[r] - 'a'] = r; 
            
           
            if (lastSeen[0] != -1 && lastSeen[1] != -1 && lastSeen[2] != -1) {
                count += 1 + Math.Min(lastSeen[0], Math.Min(lastSeen[1], lastSeen[2]));
            }
        }
        return count;
    }
}
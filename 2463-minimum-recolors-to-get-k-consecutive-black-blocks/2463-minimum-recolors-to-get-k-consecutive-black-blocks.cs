using System;
using System.Linq;

public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int minRecolors = blocks.Take(k).Count(c => c == 'W');
        int currentWhiteCount = minRecolors;

        
        for (int i = k; i < blocks.Length; i++) {
            if (blocks[i - k] == 'W') currentWhiteCount--; 
            if (blocks[i] == 'W') currentWhiteCount++;     

            minRecolors = Math.Min(minRecolors, currentWhiteCount);
        }

        return minRecolors;
    }
}

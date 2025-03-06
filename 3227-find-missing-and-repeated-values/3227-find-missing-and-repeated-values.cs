using System;
using System.Linq;

public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        var flattening = grid
            .SelectMany(g => g)
            .OrderBy(x => x)
            .ToArray();
        
        Console.WriteLine(string.Join(", ", flattening));
        
        int repeated = -1, missing = -1;
        int n = flattening.Length;

        
        for (int i = 1; i < n; i++) {
            if (flattening[i] == flattening[i - 1]) {
                repeated = flattening[i];
                break;
            }
        }

       
        int expectedSum = (n * (n + 1)) / 2; 
        int actualSum = flattening.Sum() - repeated; 
        missing = expectedSum - actualSum;

        return new int[] { repeated, missing };
    }
}

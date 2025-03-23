using System;
using System.Linq;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] result = nums1.Concat(nums2).OrderBy(x => x).ToArray(); // Merge and sort
        
        int n = result.Length;
        if (n % 2 == 0) {
            
            return (result[n / 2 - 1] + result[n / 2]) / 2.0;
        } else {
           
            return result[n / 2];
        }
    }
}

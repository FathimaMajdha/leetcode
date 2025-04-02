using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        if (nums == null || nums.Length < 3) return new List<IList<int>>();

        Array.Sort(nums);
        HashSet<string> uniqueTriplets = new HashSet<string>();
        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    string tripletKey = $"{nums[i]},{nums[left]},{nums[right]}";

                    if (!uniqueTriplets.Contains(tripletKey)) {
                        uniqueTriplets.Add(tripletKey);
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    }
                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return result;
    }
}

public class Solution {
    public int MinimumDistance(int[] nums) {
        var map = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (!map.ContainsKey(nums[i])) {
                map[nums[i]] = new List<int>();
            }
            map[nums[i]].Add(i);
        }
        
        int minDist = int.MaxValue;
        bool found = false;
        
        foreach (var list in map.Values) {
            if (list.Count >= 3) {
                for (int i = 0; i <= list.Count - 3; i++) {
                    int dist = 2 * (list[i + 2] - list[i]);
                    if (dist < minDist) {
                        minDist = dist;
                    }
                }
                found = true;
            }
        }
        
        return found ? minDist : -1;
    }
}

//Example 1: nums = [1,2,1,1,3]

//Indices of 1 → [0, 2, 3]
//Possible span: 3 - 0 = 3 → distance = 2*3 = 6
//Output: 6

//Example 2: nums = [1,1,2,3,2,1,2]

//Indices of 2 → [2, 4, 6]
//Span: 6 - 2 = 4 → distance = 2*4 = 8
//Output: 8
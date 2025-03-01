public class Solution {
    public int[] ApplyOperations(int[] nums) {
        for(int i=0;i<nums.Length-1;i++){

             if (nums[i] == nums[i + 1]) {
                nums[i]=nums[i]*2;
                nums[i + 1] = 0;
            }
        }
        int[] result = new int[nums.Length];
        int end=0;
        for (int i = 0; i <nums.Length ; i++) {
            if (nums[i] != 0) {
                result[end++] = nums[i];
            }
        }

        return result;
        
    }
}
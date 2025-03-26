public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length ==0 )
        return 0;
        int pValue = nums[0];
        int sortedIndex=0;
        for(int i=1;i<nums.Length;i++){
           if(pValue != nums[i]){
            sortedIndex++;
            nums[sortedIndex]=nums[i];
            pValue=nums[i];
           }
        }
        return sortedIndex+1;
    }
}
/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let freq = {};
    let majorityLimit = nums.length / 2;

    for (let num of nums) {
        freq[num] = (freq[num] || 0) + 1;
        if (freq[num] > majorityLimit) {
            return num;
        }
    }

    return 0; // No majority element found
};

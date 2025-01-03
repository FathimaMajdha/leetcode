/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let count = {};
    let majorityLimit = nums.length / 2;

    for (let num of nums) {
        count[num] = (count[num] || 0) + 1;
        if (count[num] > majorityLimit) {
            return num;
        }
    }

    return 0;
};

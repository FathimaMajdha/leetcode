/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findErrorNums = function(nums) {
    let n = nums.length;
    let duplicate = -1, missing = -1;
    let count = new Array(n + 1).fill(0);

    for (let i = 0; i < nums.length; i++) {
        count[nums[i]]++;
    }
    for (let i = 1; i <= n; i++) {
        if (count[i] === 2) {
            duplicate = i; 
        } else if (count[i] === 0) {
            missing = i;
        }
    }

    return [duplicate, missing];
};

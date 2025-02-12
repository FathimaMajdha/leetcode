/**
 * @param {number[]} nums
 * @return {number}
 */
var maximumSum = function (nums) {
    let maxSum = -1; 
    let digitSumMap = new Map(); 

    for (let num of nums) {
        let sumOfDigits = num
            .toString()
            .split('')
            .map(Number)
            .reduce((sum, digit) => sum + digit, 0); 

        if (digitSumMap.has(sumOfDigits)) {
            
            maxSum = Math.max(maxSum, num + digitSumMap.get(sumOfDigits));
            
            digitSumMap.set(sumOfDigits, Math.max(num, digitSumMap.get(sumOfDigits)));
        } else {
            digitSumMap.set(sumOfDigits, num);
        }
    }

    return maxSum;
};

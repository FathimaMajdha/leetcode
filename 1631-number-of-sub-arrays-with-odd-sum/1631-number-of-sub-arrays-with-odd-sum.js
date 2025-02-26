/**
 * @param {number[]} arr
 * @return {number}
 */
var numOfSubarrays = function(arr) {
    let oddCount = 0, evenCount = 1, sum = 0, totalCount = 0;
    const MOD = 1e9 + 7; 

    arr.reduce((_, num) => {
        sum += num;
        
        if (sum % 2 !== 0) {
            totalCount = (totalCount + evenCount) % MOD;
            oddCount++;
        } else {
            totalCount = (totalCount + oddCount) % MOD;
            evenCount++;
        }
    }, 0);

    return totalCount;
};



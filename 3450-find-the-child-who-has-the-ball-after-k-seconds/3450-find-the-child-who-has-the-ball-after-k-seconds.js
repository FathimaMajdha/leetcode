/**
 * @param {number} n
 * @param {number} k
 * @return {number}
 */
var numberOfChild = function(n, k) {
    return (n - 1) - Math.abs((n - 1) - k % ((n - 1) * 2));
};
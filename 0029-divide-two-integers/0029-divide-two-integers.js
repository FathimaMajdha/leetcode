/**
 * @param {number} dividend
 * @param {number} divisor
 * @return {number}
 */
var divide = function(dividend, divisor) {
    if (dividend === -2147483648 && divisor === -1) {
        return 2147483647;
    }
    let result = parseInt(dividend / divisor);
    return Math.floor(result);
};

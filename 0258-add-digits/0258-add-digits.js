/**
 * @param {number} num
 * @return {number}
 */
var addDigits = function(num) {
    while (num >= 10) {
        num = num
            .toString()
            .split('')
            .map(digit => parseInt(digit))
            .reduce((sum, digit) => sum + digit, 0);
    }
    return num;
};

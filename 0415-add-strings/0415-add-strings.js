/**
 * @param {string} num1
 * @param {string} num2
 * @return {string}
 */
var addStrings = function(num1, num2) {
    let rslt=BigInt(num1);
    let rslt1=BigInt(num2);
    let sum=rslt+rslt1;
    return sum.toString();  
};
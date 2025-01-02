/**
 * @param {number} n
 * @return {boolean}
 */
var isPowerOfThree = function(n) {
    if(n<=0) return false;
    let power=1;
    while(power<n){
        power *= 3;
    }
    return power===n;
};
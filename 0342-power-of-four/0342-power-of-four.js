/**
 * @param {number} n
 * @return {boolean}
 */
var isPowerOfFour = function(n) {
    if(n<=0) return false;
    let power=1;
    while(power < n){
        power *= 4;
    }
    return power === n;
};
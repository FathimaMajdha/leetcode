/**
 * @param {string} jewels
 * @param {string} stones
 * @return {number}
 */
var numJewelsInStones = function(jewels, stones) {
    let count=0;
    let jewels1=jewels.split('')
    let stones1=stones.split('')
    for(let i=0;i<jewels1.length;i++){
        for(let j=0;j<stones1.length;j++){
            if(jewels1[i]=== stones1[j]){
               count++;
            }
        }
    }
    return count;
};
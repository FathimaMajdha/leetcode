/**
 * @param {number[]} nums
 * @return {number[]}
 */
var singleNumber=function(nums){
    let freqMap=new Map();
    for (let num of nums){
        freqMap.set(num,(freqMap.get(num)||0)+1);
    }
    return [...freqMap.keys()].filter(num=>freqMap.get(num)===1);
};
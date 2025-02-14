/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    let word=s.split(' ');
    for(let i=word.length-1;i>=0;i--){
        if(word[i].length>0){
            return word[i].length;
        }

    }
    return 0;
};
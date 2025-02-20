/**
 * @param {string[]} word1
 * @param {string[]} word2
 * @return {boolean}
 */
var arrayStringsAreEqual = function (word1, word2) {
    let first = "";
    let second = ""
    for (let i = 0; i < word1.length; i++) {
        for (let i = 0; i < word2.length; i++) {
            first += word1.join('')
            second += word2.join('')
        }
    }
    if (first == second) {
        return true
    } else {
        return false
    }

};
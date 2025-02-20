/**
 * @param {string[]} word1
 * @param {string[]} word2
 * @return {boolean}
 */
var arrayStringsAreEqual = function (word1, word2) {

    for (let i = 0; i < word1.length; i++) {
        for (let i = 0; i < word2.length; i++) {
            if (word1.join('') == word2.join('')) {
                return true
            } else {
                return false
            }

        }
    }

};
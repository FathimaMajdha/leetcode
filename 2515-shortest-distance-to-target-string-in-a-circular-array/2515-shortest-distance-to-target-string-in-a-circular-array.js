/**
 * @param {string[]} words
 * @param {string} target
 * @param {number} startIndex
 * @return {number}
 */


   var closestTarget = function(words, target, startIndex) {
    let n = words.length;
    let min = Infinity;

    for (let i = 0; i < n; i++) {
        if (words[i] === target) {
            let diff = Math.abs(i - startIndex);
            min = Math.min(min, diff, n - diff);
        }
    }

    return min === Infinity ? -1 : min;
};
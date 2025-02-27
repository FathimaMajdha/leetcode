/**
 * @param {number} n
 * @param {number} t
 * @return {number}
 */
var smallestNumber = function(n, t) {
    if (t === 1) return n;

    while (true) {
        let digitProduct = n.toString()
            .split('')
            .map(digit => parseInt(digit))
            .reduce((product, digit) => product * digit, 1);

        if (digitProduct % t === 0) {
            return n;
        }
        n++; 
        
    }
};


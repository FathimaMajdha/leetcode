/**
 * @param {number} n
 * @param {number} t
 * @return {number}
 */
var smallestNumber = function(n, t) {
    // If t is 1, return n directly (as any number's digit product is divisible by 1)
    if (t === 1) return n;

    while (true) {
        let digitProduct = n.toString()
            .split('')
            .map(digit => parseInt(digit))
            .reduce((product, digit) => product * digit, 1);

        if (digitProduct % t === 0) {
            return n;
        }
        n++;  // Increment and check next number
        
    }
};

// Test cases
console.log(smallestNumber(2, 1)); // Expected output: 2
console.log(smallestNumber(2, 5)); // Expected output: 5
console.log(smallestNumber(1, 3)); // Expected output: 12

/**
 * @param {number[][]} matrix
 * @return {void} Do not return anything, modify matrix in-place instead.
 */
var rotate = function(matrix) {
     let arr = new Array(matrix.length).fill(null).map(() => []); 
    let mat = matrix.flat();
    let i=0;
    let row=0;
    while(i<mat.length){
        if(row>=matrix.length){
            row=0;
        }
        arr[row].unshift(mat[i]);
        i++;
        row++;
    }
    for (let i = 0; i < matrix.length; i++) {
        matrix[i] = arr[i];
    }

};
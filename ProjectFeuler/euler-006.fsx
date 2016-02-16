
let square x = x * x
let sumOfSquares = (Seq.map square) >> Seq.sum
let squareSum = (Seq.reduce (+)) >> square
let diffFirst n = squareSum {1L..n} - sumOfSquares {1L..n}

let theDiff = diffFirst 100L

(*
Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
*)

let numbers =
    let parseBigInt x = System.Numerics.BigInteger.Parse(x)
    System.IO.File.ReadAllLines(__SOURCE_DIRECTORY__ + "/euler-013.txt")
    |> Array.map parseBigInt
    
let sum = numbers |> Array.sum
sum.ToString().Substring(0,10)
(*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
*)
open System

let findFactorsOf (n : int64) = 
    let upperBound = int64 (Math.Sqrt(double (n)))
    seq { 2L..upperBound } |> Seq.filter (fun x -> n % x = 0L)

let isPrime (n:int64) =
    (findFactorsOf n |> Seq.length) = 0

seq {2L..System.Int64.MaxValue} 
|> Seq.filter isPrime
|> Seq.take 10001
|> Seq.last
   
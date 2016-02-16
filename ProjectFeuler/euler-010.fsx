(*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
*)

#load "primes.fsx"
open Primes

let sumOfPrimesBelow n =
    {2L..n}
    // |> Seq.filter (fun x -> x % 2L <> 0L) 
    |> Seq.filter isPrime
    |> Seq.sum
    
let sum10 = sumOfPrimesBelow 2000000L
    

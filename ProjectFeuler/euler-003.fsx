// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
open System

let isprime (number : bigint) =
    seq { bigint(2) .. bigint(Math.Sqrt(float number))}
    |> Seq.exists (fun x -> if (number % x = bigint(0)) then true else false)
    |> not

    
let n = 600851475143I

let primeFactors (x:bigint) = 
    seq { 2I..x }
    |> Seq.filter (fun i -> x % i = 0I)
    |> Seq.filter isprime

// primeFactors n |> Seq.iter (printf "%A ")
primeFactors n
|> Seq.max
|> printfn "%A"
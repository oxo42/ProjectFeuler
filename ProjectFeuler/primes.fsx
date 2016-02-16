
let findFactorsOf (n : int64) = 
    let upperBound = int64 (System.Math.Sqrt(double (n)))
    seq { 2L..upperBound } |> Seq.filter (fun x -> n % x = 0L)

let isPrime (n:int64) =
    (findFactorsOf n |> Seq.length) = 0

// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

let generator (a, b) = Some (a + b, (b, a + b))
let fibSeq = Seq.unfold generator (0, 1)

fibSeq 
|> Seq.filter (fun x -> x % 2 = 0)
|> Seq.takeWhile (fun x -> x < 4000000) 
|> Seq.sum 
|> printfn "Sum %A"
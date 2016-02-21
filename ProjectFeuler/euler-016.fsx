(* 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 21000?
*)

let digitSum (n:bigint) = n.ToString() |> Seq.sumBy (fun x -> int32(x.ToString()))
        
let answer = digitSum (2I**1000)
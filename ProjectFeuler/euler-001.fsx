let multipleOf3Or5 x =
    x % 3 = 0 || x % 5 = 0
     
[1..999]
|> Seq.filter multipleOf3Or5
|> Seq.sum
|> (printfn "%A")
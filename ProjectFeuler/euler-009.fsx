let isTriplet (a, b, c) = a*a + b*b = c*c
let sumTriplet (a, b, c) = a + b + c
let prodTriplet (a, b, c) = a * b * c

let s = {200..500}


(* s 
|> Seq.collect (fun a -> s |> Seq.collect (fun b -> s |> Seq.map (fun c-> (a,b,c))))
|> Seq.filter isTriplet
|> Seq.filter (fun s -> sumTriplet s = 1000)
|> Seq.toList
|> Seq.head
|> prodTriplet
*)

seq {
    for a in {200..500} do
    for b in {200..500} do
    for c in {200..500} do
        if a + b + c = 1000 then
            yield (a,b,c)
}
|> Seq.filter isTriplet
|> Seq.head
|> prodTriplet
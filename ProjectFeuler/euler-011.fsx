(* 
In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?
*)

let grid = 
    let parseInt x = System.Int32.Parse(x)
    let split (str:string) = str.Split(' ') |> Array.map parseInt 
    
    let f = System.IO.File.ReadAllLines(__SOURCE_DIRECTORY__ + "/euler-011.txt")|> Array.map split
    
    let height = f |> Array.length
    let width = f.[0] |> Array.length
       
    Array2D.init width height (fun i j -> f.[j].[i])

let loggy x = printfn "%A" x ; x
    
let calcProd xs ys =
    List.map2 (fun x y -> grid.[x,y]) xs ys
    |> loggy
    |> List.reduce (*)    

let calcRightProd i j = calcProd [i..(i+3)] (List.replicate 4 j)
let calcDownProd i j = calcProd (List.replicate 4 i) [j..(j+3)]
let calcDownDiagProd i j = calcProd [i..(i+3)] [j..(j+3)]
let calcUpDiagProd i j = calcProd [i..(i+3)] (List.rev [(j-3)..j])

let width = (Array2D.length1 grid) 
let height = (Array2D.length2 grid)

let calculateProducts f is js = seq {
    for i in is do
    for j in js do
        // printfn "(%i,%i)=%i" i j grid.[i,j]
        yield f i j    
}


let calcRightProducts = calculateProducts calcRightProd [0..(width-4)] [0..(height-1)]
let calcDownProducts = calculateProducts calcDownProd [0..(width-1)] [0..(height-4)]
let calcDownDiagProducts = calculateProducts calcDownDiagProd [0..(width-4)] [0..(height-4)]
let calcUpDiagProducts = calculateProducts calcUpDiagProd [0..(width-4)] [3..(height-1)] 
 
[calcRightProducts ; calcDownProducts ; calcDownDiagProducts ; calcUpDiagProducts]
|> List.map Seq.max

(* Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

How many such routes are there through a 20×20 grid?
*)

let factorial n =
    let rec fac n accum =
        if n <= 1I then
            accum
        else
            fac (n-1I) (n*accum)
            
    fac n 1I
    
let combine n r = factorial n / (factorial (n-r) * factorial r)
 
combine 40I 20I
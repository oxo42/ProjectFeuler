(*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.
*)

open System.Collections.Generic

let nextNumber n = if n%2L=0L then n/2L else 3L*n+1L

let memoize f =
    let cache = Dictionary<_,_>()
    fun x ->
        if cache.ContainsKey(x) then cache.[x] 
        else
            let res = f x
            cache.[x] <- res
            res

let collatzLength n =
    let rec inner n =
        match n with
        | 1L -> 1L
        | _ -> 1L + inner (nextNumber n)
        
    memoize inner n

[1L..1000000L]
|> List.maxBy collatzLength
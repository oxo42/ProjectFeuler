// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

let isPalindrome (n:int) =
    let rec isPal str index =
        let strLen = String.length str
        if index > (strLen / 2) then
            true
        elif str.[index] = str.[(strLen - index - 1)] then
            isPal str (index + 1)
        else 
            false
            
    isPal (n.ToString()) 0

let max=999

[1..max] |> List.collect (fun i -> [1..max] |> List.map (fun j -> i * j)) 
|> List.filter isPalindrome
|> List.max
|> (printfn "Max palindrom is %A")
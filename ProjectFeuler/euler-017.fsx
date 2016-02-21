(*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*)


let onesToWord prefix n postfix =
    match n with
    | 1 -> prefix + "one" + postfix
    | 2 -> prefix + "two" + postfix
    | 3 -> prefix + "three" + postfix
    | 4 -> prefix + "four" + postfix
    | 5 -> prefix + "five" + postfix
    | 6 -> prefix + "six" + postfix
    | 7 -> prefix + "seven" + postfix
    | 8 -> prefix + "eight" + postfix
    | 9 -> prefix + "nine" + postfix
    | _ -> ""
 
let teensToWord prefix ones = 
    match ones with
        | 0 -> prefix + "ten"
        | 1 -> prefix + "eleven"
        | 2 -> prefix + "twelve"
        | 3 -> prefix + "thirteen"
        | 4 -> prefix + "fourteen"
        | 5 -> prefix + "fifteen"
        | 6 -> prefix + "sixteen"
        | 7 -> prefix + "seventeen"
        | 8 -> prefix + "eighteen"
        | 9 -> prefix + "nineteen"
        | _ -> ""
           
let tensToWord prefix tens ones =
    match tens with
    | 0 -> onesToWord prefix ones ""
    | 1 -> teensToWord prefix ones
    | 2 -> prefix + "twenty" + (onesToWord "" ones "")
    | 3 -> prefix + "thirty" + (onesToWord "" ones "")
    | 4 -> prefix + "forty" + (onesToWord "" ones "")
    | 5 -> prefix + "fifty" + (onesToWord "" ones "")
    | 6 -> prefix + "sixty" + (onesToWord "" ones "")
    | 7 -> prefix + "seventy" + (onesToWord "" ones "")
    | 8 -> prefix + "eighty" + (onesToWord "" ones "")
    | 9 -> prefix + "ninety" + (onesToWord "" ones "")
    | _ -> ""

let toWord n =
    let thousands = n / 1000
    let hundreds = n % 1000 / 100
    let tens = n % 100 / 10
    let ones = n % 10
    
    let thousandsWord = onesToWord "" thousands "thousand"
    let hundredsWord = onesToWord "" hundreds "hundred"
    let tensPrefix = if (thousands > 0 || hundreds > 0) && (tens > 0 || ones > 0)
                     then "and"
                     else ""
    let tensWord = tensToWord tensPrefix tens ones
 
    thousandsWord + hundredsWord + tensWord
    
let answer = [1 .. 1000] |> List.map toWord |> List.sumBy (fun s -> s.Length)
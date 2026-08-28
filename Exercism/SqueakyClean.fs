module SqueakyClean

open System

let transform (c: char) : string =
    match c with
    | '-' -> "_"
    | letter when Char.IsUpper letter -> $"-{Char.ToLower letter}"
    | ' ' -> ""
    | letter when Char.IsDigit letter -> ""
    | letter when Char.IsBetween(letter, 'α', 'ω') -> "?"
    | _ -> string c

let clean (identifier: string) : string = 
    identifier |> Seq.map transform |> String.concat ""
module Bob

open System

let upperCaseLetterOrSomethingElse (c: char) =
    if Char.IsLetter(c) then Char.IsUpper(c) else true

let isYelling (input: string) =
    input |> Seq.forall upperCaseLetterOrSomethingElse

let isQuestion (input: string) = input.Trim().EndsWith('?')
let hasLetters (input: string) = input |> Seq.exists Char.IsLetter

let response (input: string) : string =
    match input with
    | input when String.IsNullOrWhiteSpace input -> "Fine. Be that way!"
    | input when hasLetters input && isQuestion input && isYelling input -> "Calm down, I know what I'm doing!"
    | input when hasLetters input && isYelling input -> "Whoa, chill out!"
    | input when isQuestion input -> "Sure."
    | _ -> "Whatever."



module Program

open System

// printfn "awaiting input"
// let input = Console.ReadLine()
// printfn $"{Bob.response input}"

let date  = BookingUpForBeauty.schedule "2024-07-01 12:00:00"
let dateString = date.ToString()
Console.WriteLine dateString

let hasPassed = BookingUpForBeauty.hasPassed date
Console.WriteLine (hasPassed.ToString())

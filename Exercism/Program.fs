module Program
open System

printfn "awaiting input"
// let input = Console.ReadLine()
// let guess = int input
// printfn $"{GuessingGame.reply guess}"
//
// // let date  = BookingUpForBeauty.schedule "2024-07-01 12:00:00"
// // let dateString = date.ToString()
// // Console.WriteLine dateString
// //
// // let hasPassed = BookingUpForBeauty.hasPassed date
// // Console.WriteLine (hasPassed.ToString())


let lastWeek = BirdWatcher.lastWeek
let yesterday = BirdWatcher.yesterday lastWeek

printfn $"{yesterday}"

let total = BirdWatcher.total lastWeek
printfn $"{total}"

let dayWithoutBirds = BirdWatcher.dayWithoutBirds lastWeek
printfn $"{dayWithoutBirds}"

let incremented = BirdWatcher.incrementTodaysCount lastWeek
let strings = incremented |> Array.map (_.ToString()) |> Array.fold (fun x y -> x + ", " + y) ""
printfn $"{strings}"
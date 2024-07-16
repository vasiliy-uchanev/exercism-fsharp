module InterestIsInteresting

open System

let interestRate (balance: decimal) : single =
    match balance with
    | balance when balance < 0m -> 3.213f
    | balance when balance < 1000m -> 0.5f
    | balance when balance < 5000m -> 1.621f
    | _ -> 2.475f

let interest (balance: decimal) : decimal =
    let rate = interestRate balance
    balance * decimal rate / 100m

let annualBalanceUpdate (balance: decimal) : decimal =
    let interestAmount = interest balance
    balance + interestAmount

let amountToDonate (balance: decimal) (taxFreePercentage: float) : int =
    if balance < 0m then
        0
    else
        int (Math.Floor(balance * decimal taxFreePercentage * 2m / 100m))

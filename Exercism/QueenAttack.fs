module QueenAttack

let create (position: int * int) =
    let x, y = position
    x >= 0 && x < 8 && y >= 0 && y < 8

let canAttack (queen1: int * int) (queen2: int * int) =
    let queen1X, queen1Y = queen1
    let queen2X, queen2Y = queen2
    queen1X = queen2X
        || queen1Y = queen2Y
        || queen1X - queen1Y = queen2X - queen2Y
        || queen1X + queen1Y = queen2X + queen2Y
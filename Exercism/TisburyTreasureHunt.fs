module TisburyTreasureHunt

let getCoordinate (line: string * string): string = snd line

let convertCoordinate (coordinate: string): int * char =
    let coordinate1 = coordinate[0] |> System.Char.ToString |> int
    let coordinate2 = char coordinate[1]
    (coordinate1, coordinate2)

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool =
    let azarasCoordinateString = getCoordinate azarasData
    let azarasCoordinate = convertCoordinate azarasCoordinateString
    let _, ruisCoordinate, _ =  ruisData
    azarasCoordinate = ruisCoordinate

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    let matchFound = compareRecords azarasData ruisData
    if matchFound then
        let treasure, coordinates = azarasData
        let location, _, quadrant = ruisData
        (coordinates, location, quadrant, treasure)
    else
        ("", "", "", "")
    

open System
open System.IO

let meanScore (row: string) =
    let elements = row.Split('\t')

    // let meanScore = 
    //     elements
    //     |> Array.skip 2
    //     |> Array.map float
    //     |> Array.average

    let meanScore = 
        elements
        |> Array.skip 2
        |> Array.averageBy float

    printfn "Mean Score: %.2f" meanScore

// printfn "%s" row

let readFile filePath =
    let rows = File.ReadAllLines(filePath)
    let rowCount = rows.Length - 1
    printfn "Number of rows: %i" rowCount
    rows |> Array.skip 1 |> Array.iter meanScore

[<EntryPoint>]
let main argv =
    if argv.[0].Length > 0 then
        let filePath = argv.[0]

        if (not (File.Exists(filePath))) then
            printfn "File does not exist"
        else
            printfn "Path: %s" filePath
            readFile filePath
    else
        printfn "Please pass file path"

    0

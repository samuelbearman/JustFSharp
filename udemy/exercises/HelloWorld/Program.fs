open System

let printAllargs (args: string []) =
    for arg in args do
        printfn "%s" arg

let sayHello arg = printfn "Hello there, %s" arg

let isValidName name = not (String.IsNullOrWhiteSpace name)

[<EntryPoint>]
let main argv =
    let validNames = argv |> Array.filter isValidName

    Array.iter sayHello validNames

    // or

    argv
    |> Array.filter isValidName
    |> Array.iter sayHello

    // let message =
    //     if(argv.Length > 0) then
    //         argv.[0]
    //     else
    //         "Anon"

    // printfn "Hello there, %s" message

    // Array.iter sayHello argv

    // printAllargs argv
    0 // return an integer exit code

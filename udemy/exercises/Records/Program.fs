open System

type Student = 
    {
        Name: string
        Id: string
        MeanGrade: float
        MaxGrade: float
        MinGrade: float
    }

module Student =

    let fromString(input : string) = 
        let elements = input.Split('\t')
        let name = elements.[0]
        let id = elements.[1]
        {
            Id = id
            Name = name
            MaxGrade = 100.0
            MinGrade = 100.0
            MeanGrade = 100.0
        }

[<EntryPoint>]
let main argv = 
    let someStringFromFile = "Sam, Bearman  123456"
    let studentRecord = Student.fromString(someStringFromFile)
    0

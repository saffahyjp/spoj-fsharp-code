open System

module main =
    let rec readlines () = seq {
        let line = Console.ReadLine()
        if line <> null then
            yield line
            yield! readlines ()
    }

    let folder out x =
        let new_out = if x = "42" then ignore else out
        new_out x
        new_out

    readlines () |> Seq.fold folder (printfn "%s") |> ignore

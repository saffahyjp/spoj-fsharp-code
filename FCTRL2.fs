open System

module main =
    let rec readlines () = seq {
        let line = Console.ReadLine()
        if line <> null then
            yield line
            yield! readlines ()
    }

    let rec solve x =
        if x = 0 then bigint 1 else solve (x - 1) * bigint x

    readlines ()
    |> Seq.skip 1
    |> Seq.map int
    |> Seq.map solve
    |> Seq.map string
    |> fun x -> String.Join ("\n", x)
    |> printf "%s"

    ()

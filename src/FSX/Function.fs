namespace FSX

[<AutoOpen>]
module Function =

    let identity a = a

    let constVoid _ = ()

    let flip f a b = f b a

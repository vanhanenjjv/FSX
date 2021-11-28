namespace FSX

type Either<'left, 'right> =
  | Left of 'left
  | Right of 'right

module Either =
  let map ab =
    function
    | Left l -> l |> Left
    | Right a -> ab a |> Right

  let mapLeft ab =
    function
    | Left a -> ab a |> Left
    | Right r -> r |> Right

  let chain ab =
    function
    | Left l -> l |> Left
    | Right a -> ab a

  let chainFirst ab =
    function
    | Left l -> l |> Left
    | Right a -> ab a |> function
                         | Left l -> l |> Left
                         | Right _ -> a |> Right

  let isLeft =
    function
    | Left _ -> true
    | Right _ -> false

  let isRight =
    function
    | Left _ -> false
    | Right _ -> true
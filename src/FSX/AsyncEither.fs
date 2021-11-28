namespace FSX

type AsyncEither<'left, 'right> = Async<Either<'left, 'right>>

module AsyncEither =
  let ofEither (e: Either<'left, 'right>) = async { return e }

  let map ab e =
    async {
      let! e' = e
      return match e' with
             | Left l -> l |> Left
             | Right a -> ab a |> Right }

  let mapLeft ab e =
     async {
      let! e' = e
      return match e' with
             | Left a -> ab a |> Left
             | Right r -> r |> Right }

  let chain ab e =
    async {
      let! e' = e
      return! match e' with
              | Left l -> l |> Left |> ofEither
              | Right a -> ab a }

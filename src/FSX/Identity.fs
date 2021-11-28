namespace FSX

type Identity<'a> = 'a

module Identity =
  let map ab a = ab a

  let chain = map

  let chainFirst ab a =
    a |> ab |> ignore
    a

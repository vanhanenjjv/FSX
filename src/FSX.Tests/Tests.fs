module Tests

open System
open Xunit

open FSX

[<Fact>]
let ``fax`` () =
  Assert.Equal(2 |> Right |> Either.isRight, true)

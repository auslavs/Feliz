namespace Sample

open Fable.Core
open Feliz


[<Erase; Mangle(false)>]
type Components =

    [<ReactComponent>]
    static member Counter(?init: int) =
        let init = defaultArg init 0
        let counter, setCounter = React.useState(init)
        Html.div [
            prop.children [
                Html.h1 "Counter"
                Html.p [
                    prop.text (sprintf "Current count: %d" counter)
                ]
                Html.button [
                    prop.text "Increment"
                    prop.onClick (fun _ -> setCounter (counter + 1))
                ]
                Html.button [
                    prop.text "Decrement"
                    prop.onClick (fun _ -> setCounter (counter - 1))
                ]
            ]
        ]

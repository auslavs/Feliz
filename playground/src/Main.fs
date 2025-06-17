module Main

open Feliz
open Browser.Dom

[<Fable.Core.JSX.ComponentAttribute>]
let View() =
    Html.div [
        Components.Components.LazyLoad()
    ]

let private root = ReactDOM.createRoot(document.getElementById "root")
root.render(View())



module App

open Feliz
open Browser.Dom
open Fable.Core

[<ReactComponent>]
let MyCounter() =
    let (count, setCount) = React.useState(0)
    JSX.jsx $"""
        <div>
            {count}
            <div>
                <button onDoubleClick onClick={fun _ -> setCount(count + 1)}>Increment</button>
            </div>
            <div>
                <button onClick={fun _ -> setCount(count - 1)} >Decrement</button>
            </div>
        </div>
    """
    |> unbox<ReactElement>

let App() =
    Html.div [
        prop.children [
            Components.Components.Testing()
            MyCounter()
        ]
    ]

module Interpreter

open Structure

exception Exception of string

//let rec evaluateExpression variables expression =
//    match expression with
//    | Value v -> v
//    | Var id -> 
//        match Map.tryFind id variables with
//        | Some value -> value
//        | None -> raise(Exception("Exceptionnnn!!")) //the raise method creates an exception
//    | 


let rec evaluateStatement variables statement : Map<string, ValueType> =
    match statement with
    | Block block ->
        block |> List.fold(fun updatedVariables statement -> evaluateStatement updatedVariables statement) variables //fold is iterating through the block and executes 'evaluateStatement' and returns variables
        
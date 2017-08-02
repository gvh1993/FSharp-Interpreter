module Structure

// Declerations
type ValueType =
    | String of string
    | Integer of int
    | Boolean of bool
    | Float of float
    | Double of double

//
//
//type Decleration = {
//    Type: Type;
//    Name: string
//}
//
//let Declerate (typeValue : 'a) (name : 'b) =
    
    
// printfn


type Expression = 
    | Value of ValueType
    | Var of string

    // Arithmetic operators
    // add, minus, multiplication, dividing, modulus
    // * is for creating a tuple
    | Add of Expression * Expression
    | Subtract of Expression * Expression
    | Divide of Expression * Expression
    | Multiply of Expression * Expression
    | Modulo of Expression * Expression

// Logical operators
// TODO equals, greater than, less than, not equals, OR, AND



// while, for, if, else
type Statement =
    | Block of Statement list
    | If of Expression * Statement
    | Elif of Expression * Statement * Statement
    | While of Expression * Statement


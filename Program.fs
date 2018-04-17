// Learn more about F# at http://fsharp.org

open System
open System.Threading.Tasks

// simple types in one line
type Person = {First:string; Last:string}

// simple type
type Peppo = { Name:string; Age:int }

type SuperPeppo = Ceppa of Peppo | SuperCeppa of SuperPeppo list


// single line comment
(*  multi line comment *)

let var1 = 0
let va2 = 1.2
let val3 = "ghjklòà"

let aList = [2;3;4;5]
let oneToFive = 1 :: aList // insert 1 to new created list -> list.insert(0,...aList)
let zeroToFive = [0;1] @ aList // the at operator concatenate two lists ->  [0,1].concat(aList)

[<EntryPoint>]
let main argv =

    printfn "print string %s" "Test"

    List.iter (printfn "%d") zeroToFive

    List.iter (printfn "1 to 5 -> %d") oneToFive
    
    // let person1 = {First="john"; Last="Doe"}
    // let person2 = {First="john"; Last="Doe"}
    // printfn "Equal? %A"  (person1 = person2)

    // let jd  = { Name= "Suka"; Age=12}

    // jd.Age |> printfn "Age is %d"

    // printfn "Age of Jd is %s" ( jd.Age.ToString() )

    // let makeNewString str = 
    //     let newString = str + " new!"
    //     newString

    // printfn "Appended: %s" ( makeNewString "azzo" )

    // let a = async { printfn "ghjkl" }

    // Async.Start a

    // let wk = Ceppa jd

    // let addT = (+) 2 >> (*) 3

    // printfn "Result %d" ( addT 5 )
    
    // let square x = x * x
    // let sq = square 10

    // sq |> printfn "Sqaure is %d"

    // [1..10] |> List.sum |> printfn "sum=%d"

    0 // return an integer exit code
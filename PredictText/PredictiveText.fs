module PredictText.PredictiveText

open System.IO
open System

let private dictPath = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

///Allows you to load your own dictionary of data
let LoadDictFromPath (path:String) = 
    File.ReadAllLines path

///Load dictionary from path
let LoadDict (path:String) = 
    let dict = LoadDictFromPath path
    dict

///Filter data based on prefix and dict
let Autocomplete (prefix:String) (dict:String[]) = 
    let candidates = dict |> Array.filter(fun word -> word.StartsWith(prefix))
    candidates




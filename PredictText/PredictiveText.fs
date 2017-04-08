module PredictText.PredictiveText

open System.IO
open System

let dictPath = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

let loadDictFromPath (path:String) = 
    File.ReadAllLines path

let loadDict (path:String) = 
    let dict = loadDictFromPath path
    dict


let loadedDict= loadDict dictPath

let autocomplete (prefix:String) (dict:String[]) = 
    let candidates = dict |> Array.filter(fun word -> word.StartsWith(prefix))
    candidates

autocomplete "test" loadedDict


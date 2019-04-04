﻿[<JavaScript>]
module FSBOL.Type

open FSBOL

type Type = 
    | DNA
    | RNA
    | Protein
    | SmallMolecule
    | Complex
    | Linear
    | Circular
    | SingleStranded
    | DoubleStranded
    | OtherType of string
    static member fromURI (str:string) = 
        match str with 
        | "http://www.biopax.org/release/biopax-level3.owl#DnaRegion" -> DNA
        | "http://www.biopax.org/release/biopax-level3.owl#RnaRegion" -> RNA
        | "http://www.biopax.org/release/biopax-level3.owl#Protein" -> Protein
        | "http://www.biopax.org/release/biopax-level3.owl#SmallMolecule" -> SmallMolecule 
        | "http://www.biopax.org/release/biopax-level3.owl#Complex" -> Complex
        | "http://identifiers.org/so/SO:0000987" -> Linear
        | "http://identifiers.org/so/SO:0000988" -> Circular
        | "http://identifiers.org/so/SO:0000984" -> SingleStranded 
        | "http://identifiers.org/so/SO:0000985" -> DoubleStranded
        | _ -> OtherType(str)
    static member toURI (t:Type) = 
        match t with 
        | DNA -> "http://www.biopax.org/release/biopax-level3.owl#DnaRegion"
        | RNA -> "http://www.biopax.org/release/biopax-level3.owl#RnaRegion"
        | Protein -> "http://www.biopax.org/release/biopax-level3.owl#Protein"
        | SmallMolecule -> "http://www.biopax.org/release/biopax-level3.owl#SmallMolecule"
        | Complex -> "http://www.biopax.org/release/biopax-level3.owl#Complex"
        | Linear -> "http://identifiers.org/so/SO:0000987"
        | Circular -> "http://identifiers.org/so/SO:0000988"
        | SingleStranded -> "http://identifiers.org/so/SO:0000984"
        | DoubleStranded -> "http://identifiers.org/so/SO:0000985"
        | OtherType(s) -> s
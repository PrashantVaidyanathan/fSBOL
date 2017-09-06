﻿module FSBOL.SequenceTest

open FSBOL.Sequence
open FSBOL.Terms

open Xunit
open FsUnit.Xunit
open System
open System.Diagnostics


[<Fact>]
let ``RunTest``() = 
    let uriPrefix = "www.microsoft.com/gec/"
    let version = "1"
    let name = "pTet"
    let seq = "atcgga"
    let encoding = Terms.dnasequence
    let displayId = name;
    let s:Sequence = new Sequence(name,uriPrefix,displayId,version, seq,encoding)
    s.description <- "This is a test Sequence"

    Debug.WriteLine("Wrote it")


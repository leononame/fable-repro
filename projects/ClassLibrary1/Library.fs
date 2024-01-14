module Repro
open Fable.Core

[<Import("log", "../../../../features/accounting/amount/Amount")>]
let log: string -> unit = jsNative

[<Import("log", "pkg/log")>]
let log2: string -> unit = jsNative

let sayHello =
    log "Hello"
    log2 "World"

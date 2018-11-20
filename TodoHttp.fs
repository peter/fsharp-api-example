namespace Todos.Http

open Giraffe
open Microsoft.AspNetCore.Http

module TodoHttp =
  let handlers : HttpFunc -> HttpContext -> HttpFuncResult =
    choose [
      POST >=> route "/todos" >=>
        fun next context ->
          text "Create" next context

      GET >=> route "/todos" >=>
        fun next context ->
          text "Read" next context

      PUT >=> routef "/todos/%s" (fun id ->
        fun next context ->
          text ("Update " + id) next context)

      DELETE >=> routef "/todos/%s" (fun id ->
        fun next context ->
          text ("Delete " + id) next context)
    ]

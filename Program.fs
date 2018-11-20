module Todos.Program

open System
open System.Collections
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Todos.Http
open MongoDB.Driver
open Todos.TodoMongoDB

let routes =
    choose [
        TodoHttp.handlers
    ]

let configureApp (app : IApplicationBuilder) =
    app.UseGiraffe routes

let configureServices (services : IServiceCollection) =
    let mongo = MongoClient (Environment.GetEnvironmentVariable "MONGO_URL")
    let db = mongo.GetDatabase "todos"
    services.AddGiraffe() |> ignore
    services.AddTodoMongoDB(db.GetCollection<Todo>("todos")) |> ignore

[<EntryPoint>]
let main _ =
    WebHostBuilder()
        .UseKestrel()
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .Build()
        .Run()
    0
 
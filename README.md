# Todos - Basic CRUD Example with Giraffe and F#

## TODO

* Validation?

## Dependencies

.NET Core

## Running

```
export MONGO_URL=mongodb://localhost:27017/
```

```
dotnet run
```

Running with a watch:

```
dotnet watch run
```

## REPL

```
fsharpi
```

## Example API Calls

With httpie:

```
// list
http GET http://localhost:5000/todos

// create
http POST http://localhost:5000/todos text="something to do"

// list
http GET http://localhost:5000/todos

export TODO_ID=...

// update
http PUT http://localhost:5000/todos/$TODO_ID

// delete
http DELETE http://localhost:5000/todos/$TODO_ID
```

## Resources

* [REST API with MongoDB and F# on .NET Core (and Giraffe](https://medium.com/@leocavalcante/rest-api-with-mongodb-and-f-on-net-core-605a2336f264)
* [Giraffe Example App](https://github.com/cartermp/GiraffeSample)

namespace Todos

type Todo =
  {
    Id: string
    Text: string
    Done: bool
  }

 type TodoSave = Todo -> Todo

 type TodoCriteria =
     | All

 type TodoFind = TodoCriteria -> Todo[]

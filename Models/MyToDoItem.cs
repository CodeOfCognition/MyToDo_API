using System;
namespace MyToDo.Models
{
    public class MyToDoItem
    { 
            public long Id { get; set; }
            public string Name { get; set; }
            public bool IsComplete { get; set; }
    }
}

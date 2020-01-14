using System;
using Microsoft.EntityFrameworkCore;
namespace MyToDo.Models
{
    public class MyToDoContext : DbContext
    {
        public MyToDoContext(DbContextOptions<MyToDoContext> options)
            : base(options)
        {
        }

        public DbSet<MyToDoItem> MyToDoItems { get; set; }
    }
}

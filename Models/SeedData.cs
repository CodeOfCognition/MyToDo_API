using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MyToDo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyToDoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyToDoContext>>()))
            {
                // Look for any MyToDoItems
                if (context.MyToDoItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.MyToDoItems.AddRange(
                    new MyToDoItem
                    {
                        Id = 1,
                        Name = "Run",
                        IsComplete = false
                    },

                    new MyToDoItem
                    {
                        Id = 2,
                        Name = "Complete App",
                        IsComplete = false
                    },

                    new MyToDoItem
                    {
                        Id = 3,
                        Name = "Cook Dinner",
                        IsComplete = true
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
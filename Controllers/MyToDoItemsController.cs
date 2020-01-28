using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyToDo.Models;

namespace MyToDo.Controllers
{

    [Route("api/MyToDoItems")]
    [ApiController]
    public class MyToDoItemsController : ControllerBase
    {
        private readonly MyToDoContext _context;

        public MyToDoItemsController(MyToDoContext context)
        {
            _context = context;
        }

        // GET: api/MyToDoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyToDoItem>>> GetMyToDoItems()
        {
            return await _context.MyToDoItems.ToListAsync();
        }
        
        // GET: api/MyToDoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyToDoItem>> GetMyToDoItem(long id)
        {
            var MyToDoItem = await _context.MyToDoItems.FindAsync(id);

            if (MyToDoItem == null)
            {
                return NotFound();
            }

            return MyToDoItem;
        }

        // POST: api/MyToDoItems
        [HttpPost]
        public async Task<ActionResult<MyToDoItem>> PostMyToDoItem([FromForm]MyToDoItem myToDoItem)
        {
            _context.MyToDoItems.Add(myToDoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMyToDoItem), new { id = myToDoItem.Id }, myToDoItem);
        }


        /*

        // PUT: api/MyToDoItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyToDoItem(long id, MyToDoItem MyToDoItem)
        {
            if (id != MyToDoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(MyToDoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyToDoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }



        // DELETE: api/MyToDoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MyToDoItem>> DeleteMyToDoItem(long id)
        {
            var MyToDoItem = await _context.MyToDoItems.FindAsync(id);
            if (MyToDoItem == null)
            {
                return NotFound();
            }

            _context.MyToDoItems.Remove(MyToDoItem);
            await _context.SaveChangesAsync();

            return MyToDoItem;
        }

        private bool MyToDoItemExists(long id)
        {
            return _context.MyToDoItems.Any(e => e.Id == id);
        }
        */
    }
}

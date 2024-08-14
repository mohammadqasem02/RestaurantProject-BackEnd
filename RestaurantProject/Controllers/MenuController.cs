using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models;
using RestaurantProject.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly DataDbContext _dbContext;

        public MenuController (DataDbContext context)
        {
            _dbContext = context;
        }

        // GET: api/Menu
        [HttpGet]
        public async Task<IActionResult> GetAllMenuItems ()
        {
            var menuItems = await _dbContext.Menus.ToListAsync();
            return Ok(menuItems);
        }

        // GET: api/Menu/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuItemById (int id)
        {
            var menuItem = await _dbContext.Menus.FindAsync(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return Ok(menuItem);
        }

        // PUT: api/Menu/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuItem (int id, [FromBody] Menu menuItem)
        {
            if (id != menuItem.FoodId)
            {
                return BadRequest("ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.Entry(menuItem).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.Menus.Any(e => e.FoodId == id))
                {
                    return NotFound($"Menu item with ID {id} not found.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Menu
        [HttpPost]
        public async Task<IActionResult> PostMenuItem ([FromBody] Menu menuItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.Menus.Add(menuItem);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItemById), new
            {
                id = menuItem.FoodId
            }, menuItem);
        }
    }
}

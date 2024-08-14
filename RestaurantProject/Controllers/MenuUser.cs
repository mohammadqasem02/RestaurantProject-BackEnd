using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models;
using RestaurantProject.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuUserController : ControllerBase
    {
        private readonly DataDbContext _dbContext;

        public MenuUserController (DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // POST: api/MenuUser
        [HttpPost()]
        public async Task<IActionResult> CreateMenuUser ([FromBody] MenuUser menuUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Add the MenuUser entry to the database
            _dbContext.MenuUsers.Add(menuUser);
            await _dbContext.SaveChangesAsync();

            // Return a response, including the created resource
            return CreatedAtAction(nameof(GetMenuUser), new
            {
                id = menuUser.Id,
            }, menuUser);
        }

        // GET: api/MenuUser/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuUser (int id)
        {
            var menuUser = await _dbContext.MenuUsers.FindAsync(id);

            if (menuUser == null)
            {
                return NotFound();
            }

            return Ok(menuUser);
        }

        // PUT: api/MenuUser/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuUser (int id, [FromBody] MenuUser menuUser)
        {
            if (id != menuUser.Id)
            {
                return BadRequest("MenuUser ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingMenuUser = await _dbContext.MenuUsers.FindAsync(id);
            if (existingMenuUser == null)
            {
                return NotFound();
            }

            // Update the existing MenuUser entry with new values

            existingMenuUser.FoodId = menuUser.FoodId;
            existingMenuUser.Morning = menuUser.Morning;
            existingMenuUser.Noon = menuUser.Noon;
            existingMenuUser.Evening = menuUser.Evening;

            _dbContext.Entry(existingMenuUser).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuUserExists(id))
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

        // DELETE: api/MenuUser/{id}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuUser (int id)
        {
            var menuUser = await _dbContext.MenuUsers.FindAsync(id);
            if (menuUser == null)
            {
                return NotFound();
            }

            _dbContext.MenuUsers.Remove(menuUser);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }




        private bool MenuUserExists (int id)
        {
            return _dbContext.MenuUsers.Any(e => e.Id == id);
        }
    }
}

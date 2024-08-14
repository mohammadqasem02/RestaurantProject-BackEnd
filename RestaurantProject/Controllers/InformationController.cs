using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Data;
using RestaurantProject.Models;
using System.Threading.Tasks;

namespace RestaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly DataDbContext _context;

        public InformationController (DataDbContext context)
        {
            _context = context;
        }

        // POST: api/Information
        [HttpPost]
        public async Task<ActionResult<Information>> PostInformation (Information information)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Information.Add(information);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInformation), new
            {
                id = information.RestaurantId
            }, information);
        }

        // GET: api/Information/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Information>> GetInformation (int id)
        {
            var information = await _context.Information.FindAsync(id);

            if (information == null)
            {
                return NotFound();
            }

            return information;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Data;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaintenanceController : ControllerBase
    {
        private readonly DataDbContext _context;

        public MaintenanceController (DataDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostMaintenance ([FromBody] Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Maintenances.Add(maintenance);
                await _context.SaveChangesAsync();
                return Ok(maintenance);
            }
            return BadRequest(ModelState);
        }
    }
}

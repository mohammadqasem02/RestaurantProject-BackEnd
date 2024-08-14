using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.Data;
using RestaurantProject.Models;

namespace RestaurantProject.Controllers
{
    [Route("api")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly DataDbContext _dbContext;

        // Constructor Injection
        public AccountController (DataDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        [HttpPost("register")]

        public async Task<IActionResult> Register ([FromBody] Register user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Users.Add(user); // Ensure `Users` is the correct DbSet
                    await _dbContext.SaveChangesAsync();
                    return Ok(new
                    {
                        username = user.Username,
                        id = user.RandomId
                    });
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }

            return BadRequest(ModelState);
        }

        // GET: /Account/Login
        [HttpGet("login")]
        public IActionResult Login ()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login ([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _dbContext.Users
                    .SingleOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    // Set session or create a token if required
                    return Ok(new
                    {
                        message = "Login successful",
                        username = user.Username
                    });
                }

                return Unauthorized(new
                {
                    message = "Invalid email or password"
                });
            }

            return BadRequest(ModelState);
        }

        // GET: /Account/Logout
        [HttpPost("logout")] // Changed to POST to avoid GET requests causing side effects
        [ValidateAntiForgeryToken] // Added to protect against CSRF attacks
        public IActionResult Logout ()
        {
            // Clear session or cookies here
            HttpContext.Session.Remove("Username");

            // Redirect to home or another page
            return RedirectToAction("Index", "Home");
        }
    }
}

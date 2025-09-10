using Microsoft.AspNetCore.Mvc;
using tasking_api.Infrastructure.Context;

namespace tasking_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _db;

        public LoginController(AppDbContext db) => _db = db;

        [HttpGet("db")]
        public async Task<IActionResult> CheckDb(CancellationToken ct)
        {
            var canConnect = await _db.Database.CanConnectAsync(ct);
            return canConnect ? Ok("Database OK") : StatusCode(500, "Database connection failed");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using tasking_api.Main.Models;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskingController : ControllerBase
    {
        private readonly ILogger<TaskingController> _logger;
        private readonly IBoardService _boardService;

        public TaskingController(ILogger<TaskingController> logger, IBoardService boardService)
        {
            _logger = logger;
            _boardService = boardService;
        }

        [HttpGet("{id:guid}", Name = "GetBoard")]
        public async Task<ActionResult<Board>> Get(Guid id)
        {
            var board = await _boardService.getBoardById(id);
            if (board == null)
            {
                return NotFound();
            }
            return await _boardService.getBoardById(Guid.NewGuid());
        }
    }
}

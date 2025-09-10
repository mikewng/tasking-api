using Microsoft.AspNetCore.Mvc;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<BoardController> _logger;
        private readonly IBoardService _boardService;
        private readonly ITaskService _taskService;
        public TaskController(ILogger<BoardController> logger, IBoardService boardService, ITaskService taskService)
        {
            _logger = logger;
            _boardService = boardService;
            _taskService = taskService;
        }
    }
}

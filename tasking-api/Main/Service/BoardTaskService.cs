using tasking_api.Main.Data.Contracts;
using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO.Request;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class BoardTaskService : IBoardTaskService
    {
        private readonly IBoardTaskRepository _boardTaskRepo;
        public BoardTaskService(IBoardTaskRepository boardTaskRepository) {
            _boardTaskRepo = boardTaskRepository;
        }

        public Task<Result<BoardTask>> CreateTask(BoardTask task)
        {
            throw new NotImplementedException();
        }
        public Task<Result<BoardTask>> GetTaskById(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<Result<BoardTask>> DeleteTaskById(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<Result<BoardTask>> UpdateTask(BoardTaskRequest taskBody)
        {
            throw new NotImplementedException();
        }
    }
}


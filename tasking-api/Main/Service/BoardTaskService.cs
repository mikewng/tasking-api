using tasking_api.Main.Data;
using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO.Request;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class BoardTaskService : IBoardTaskService
    {
        private readonly ISQLRepository _sqlRepository;
        public BoardTaskService(ISQLRepository sQLRepository) {
            _sqlRepository = sQLRepository;
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


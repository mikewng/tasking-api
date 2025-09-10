using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO.Request;

namespace tasking_api.Main.Service.Contracts
{
    public interface IBoardTaskService
    {
        public Task<Result<BoardTask>> CreateTask(BoardTask task);
        public Task<Result<BoardTask>> GetTaskById(Guid id);
        public Task<Result<BoardTask>> UpdateTask(BoardTaskRequest taskBody);
        public Task<Result<BoardTask>> DeleteTaskById(Guid id);
    }
}

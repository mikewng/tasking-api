using tasking_api.Main.Models;

namespace tasking_api.Main.Service.Contracts
{
    public interface ITaskService
    {
        public Task<Result<BoardTask>> GetTaskById(Guid id);
        public Task<Result<BoardTask>> PatchTask(BoardTask task);
        public Task<Result<BoardTask>> DeleteTaskById(Guid id);
        
    }
}

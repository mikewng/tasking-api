using tasking_api.Main.Models;

namespace tasking_api.Main.Service.Contracts
{
    public interface ITaskService
    {
        public Task<BoardTask> GetTaskById(Guid id);
        public Task<BoardTask> PatchTask(BoardTask task);
        public Task<BoardTask> DeleteTaskById(Guid id);
        
    }
}

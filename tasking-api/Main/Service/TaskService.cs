using tasking_api.Main.Models;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class TaskService : ITaskService
    {
        public Task<Result<BoardTask>> DeleteTaskById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<BoardTask>> GetTaskById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<BoardTask>> PatchTask(BoardTask task)
        {
            throw new NotImplementedException();
        }
    }
}


using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO;

namespace tasking_api.Main.Data
{
    public interface IBoardTaskRepository
    {
        Task<BoardTask?> GetAsync(Guid id, CancellationToken ct);
        Task<IReadOnlyList<BoardTaskDto>> ListByBoardAsync(Guid boardId, CancellationToken ct, TaskStatus? status = null, int skip = 0, int take = 50);
        Task AddAsync(BoardTask task, CancellationToken ct);
        Task RemoveAsync(BoardTask task, CancellationToken ct);
    }
}

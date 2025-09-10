using tasking_api.Main.Models;

namespace tasking_api.Main.Data
{
    public interface IBoardRepository
    {
        Task<Board?> GetAsync(Guid id, CancellationToken ct);
        Task<Board?> GetOwnedAsync(Guid ownerId, Guid boardId, CancellationToken ct);
        Task AddAsync(Board board, CancellationToken ct);
        Task RemoveAsync(Board board, CancellationToken ct);
        Task<bool> ExistsAsync(Guid ownerId, Guid boardId, CancellationToken ct);
    }
}

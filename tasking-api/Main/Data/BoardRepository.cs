using Microsoft.EntityFrameworkCore;
using tasking_api.Infrastructure.Context;
using tasking_api.Main.Data.Contracts;
using tasking_api.Main.Models;

namespace tasking_api.Main.Data
{
    public class BoardRepository: IBoardRepository
    {
        private readonly AppDbContext _db;
        public BoardRepository(AppDbContext db) => _db = db;

        public Task AddAsync(Board board, CancellationToken ct) =>
            _db.Boards.AddAsync(board, ct).AsTask();

        public Task<bool> ExistsAsync(Guid ownerId, Guid boardId, CancellationToken ct) =>
            _db.Boards.AnyAsync(b => b.Id == boardId && b.OwnerId == ownerId, ct);

        public Task<Board?> GetAsync(Guid id, CancellationToken ct) =>
        _db.Boards.Include(b => b.Tasks).FirstOrDefaultAsync(b => b.Id == id, ct);

        public async Task<IReadOnlyList<Board>> ListOwnedAsync(Guid ownerId, CancellationToken ct) =>
            await _db.Boards.Where(b => b.OwnerId == ownerId)
            .OrderBy(b => b.Name)
            .AsNoTracking()
            .ToListAsync(ct);

        public Task RemoveAsync(Board board, CancellationToken ct)
        { 
            _db.Boards.Remove(board); return Task.CompletedTask;
        }
    }
}

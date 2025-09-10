using tasking_api.Main.Models;

namespace tasking_api.Main.Service.Contracts
{
    public interface IBoardService
    {
        public Task<Board> getBoardById(Guid id);
        public Task<Board> updateBoard(Board board);
        public Task<Board> patchBoard(Board board);
        public Task<Board> deleteBoardById(Guid id);
    }
}

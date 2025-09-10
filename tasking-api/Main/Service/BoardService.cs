using tasking_api.Main.Models;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class BoardService : IBoardService
    {
        public Task<Result<Board>> CreateBoard(string name, string description)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Board>> DeleteBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Board>> GetBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Board>> UpdateBoardInfo(Guid id, string name, string description)
        {
            throw new NotImplementedException();
        }
    }
}

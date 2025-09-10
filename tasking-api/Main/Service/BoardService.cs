using tasking_api.Main.Data.Contracts;
using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO.Request;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepo;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepo = boardRepository;
        }

        public Task<Result<Board>> CreateBoard(BoardRequest boardRequest)
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

        public Task<Result<Board>> UpdateBoardInfo(BoardRequest boardRequest)
        {
            throw new NotImplementedException();
        }
    }
}

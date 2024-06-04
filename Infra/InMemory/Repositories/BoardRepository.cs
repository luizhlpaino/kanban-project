using Domain.Entities;
using Domain.Repositories;

namespace Infra.Repositories;

public class InMemoryBoardRepository : IBoardRepository
{
    private List<Board> _boards = new List<Board>();

    public Board Create(Board board)
    {
        this._boards.Add(board);
        return board;
    }

    public void Delete(Board board)
    {
        this._boards.Remove(board);
    }

    public List<Board> GetAll()
    {
        return this._boards;
    }

    public Board Update(Board board)
    {
        this._boards = this._boards.Where(x => x.guid == board.guid).ToList();
        return board;
    }

    Task<IEnumerable<Board>> IBoardRepository.Create(Board board)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Board>> IBoardRepository.GetAll()
    {
        throw new NotImplementedException();
    }
}

using Domain.Entities;

namespace Domain.Repositories;

public interface IBoardRepository
{
    Task<IEnumerable<Board>> GetAll();
    Task<IEnumerable<Board>> Create(Board board);
    Board Update(Board board);
    void Delete(Board board);
}

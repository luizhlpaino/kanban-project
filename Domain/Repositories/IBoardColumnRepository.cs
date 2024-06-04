using Domain.Entities;

namespace Domain.Repositories;

public interface IBoardColumnRepository
{
    List<BoardColumn> GetAll();
    BoardColumn Create(BoardColumn boardColumn);
    BoardColumn Update(BoardColumn boardColumn);    
    void Delete(BoardColumn boardColumn);        
}

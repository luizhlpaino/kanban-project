using Domain.Entities;

namespace Domain.Repositories;

public interface ICardRepository
{
    List<Card> GetAll();
    Card Create(Card card);
    Card Update(Card card);
    void Delete(Card card);
}

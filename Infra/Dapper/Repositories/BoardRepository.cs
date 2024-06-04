using Domain.Entities;
using Domain.Repositories;
using Dapper;
using Npgsql;

namespace Infra.Repositories;

public class DapperBoardRepository : IBoardRepository
{
    public async Task<IEnumerable<Board>> Create(Board board)
    {
        var connectionService = new ConnectionService("bla");
        var databaseService = new DatabaseService(connectionService);

        using(var connection = databaseService.GetCompanyDatabaseConnection(new Guid("e6db93a5-c466-4e8c-8423-758455892af4"))) {
            connection.Open();
            return await connection.QueryAsync<Board>(@" 
                insert into boards (guid, title, created_at) 
                values (@BoardGuid, @BoardTitle, now())
            ", new {
                BoardGuid = board.guid,
                BoardTitle = board.title,
            });
        }
    }

    public void Delete(Board board)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Board>> GetAll()
    {
        var connectionService = new ConnectionService("bla");
        var databaseService = new DatabaseService(connectionService);

        using(var connection = databaseService.GetCompanyDatabaseConnection(new Guid("e6db93a5-c466-4e8c-8423-758455892af4"))) {
            connection.Open();
            return await connection.QueryAsync<Board>(@" 
                select b.guid
                     , b.title
                     , b.created_at
                  from boards b
            ");
        }
    }

    public Board Update(Board board)
    {
        throw new NotImplementedException();
    }
}

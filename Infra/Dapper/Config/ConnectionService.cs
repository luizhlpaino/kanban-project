using Dapper;
using Npgsql;

namespace Infra;

public class ConnectionService
{
    private readonly string _adminConnectionString;

    public ConnectionService(string adminConnectionString) {
        _adminConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=admin;";
    }

    public CompanyConnection GetCompanyConnection(Guid companyGuid) {
        using(var connection = new NpgsqlConnection(_adminConnectionString)){
            string query = @"
               select c.title as companyTitle
                    , db.name as databaseName
                    , db.host as databaseHost
                 from companies c
                 join databases db on c.databaseguid = db.guid
                where c.guid = @CompanyGuid
            ";

            return connection.QuerySingleOrDefault<CompanyConnection>(query, new { CompanyGuid = companyGuid });
        }
    }
}

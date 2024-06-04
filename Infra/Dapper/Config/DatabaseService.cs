using System.Data;
using Npgsql;

namespace Infra;

public class DatabaseService
{
    private readonly ConnectionService _connectionService;

    public DatabaseService(ConnectionService connectionService) {
        _connectionService = connectionService;
    }

    public IDbConnection GetCompanyDatabaseConnection(Guid companyGuid) {
        var companyConnection = _connectionService.GetCompanyConnection(companyGuid);
        if (companyConnection == null) {
            throw new InvalidOperationException("Company connection not found");
        }

        return new NpgsqlConnection(companyConnection.getCompanyConnectionString());
    }
}

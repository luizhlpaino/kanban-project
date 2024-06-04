namespace Infra;

public class CompanyConnection
{
    private string companyTitle {get; set;}
    private string databaseName {get; set;}
    private string databaseHost {get; set;}

    public string getCompanyConnectionString() {
        return $"Server={this.databaseHost};Port=5432;User Id=postgres;Password=123;Database={this.databaseName};";
     }
}

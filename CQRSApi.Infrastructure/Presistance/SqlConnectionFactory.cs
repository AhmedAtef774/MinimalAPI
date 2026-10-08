using System.Data;
using CQRSApi.Application.Contract.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CQRSAPi.Infrastructure.Presistance;

public class SqlConnectionFactory : IDbConnectionFactory
{
     private readonly string connectionString;


    public SqlConnectionFactory(IConfiguration configuration)
    {
        this.connectionString = configuration.GetConnectionString("SqlConnection") ?? throw new  ArgumentException("Invalid Connection");
    }


    public IDbConnection CreateConnection()
    {
        return new SqlConnection(connectionString);
    }
}
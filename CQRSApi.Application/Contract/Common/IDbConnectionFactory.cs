using System.Data;

namespace CQRSApi.Application.Contract.Common;
public interface IDbConnectionFactory {

    IDbConnection CreateConnection();

}
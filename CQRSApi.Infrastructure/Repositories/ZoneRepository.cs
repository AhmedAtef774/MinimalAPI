using CQRSApi.Application.Contract.Common;
using CQRSApi.Application.Contract.Repositories;
using CQRSApi.Domain.Entities.Zones;
using Dapper;

namespace CQRSAPi.Infrastructure.Repositories;

public class ZoneRepository : IZoneRepository
{
    private readonly IDbConnectionFactory factory;

    public ZoneRepository(IDbConnectionFactory factory)
    {
        this.factory = factory;
    }

    public async Task<List<Zone>> GetAllZonesAsync()
    {
        using var connection = factory.CreateConnection();

        var sql = @"Select * From Zones";

        var zones = await connection.QueryAsync<Zone>(sql);

        return zones.ToList();
    }
}
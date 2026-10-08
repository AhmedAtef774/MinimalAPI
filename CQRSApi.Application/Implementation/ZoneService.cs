using CQRSApi.Application.Contract.Repositories;
using CQRSApi.Application.DTOs;

public class ZoneService : IZoneService
{
    private readonly IZoneRepository repository;

    public ZoneService(IZoneRepository repository)
    {
        this.repository = repository;
    }
    public async Task<List<ZoneDto>> GetZonesAsync()
    {
        var zones = await repository.GetAllZonesAsync();

        var results = zones.Select(z => new ZoneDto {
            Name = z.Name
        }).ToList();


        return results;

    }
}
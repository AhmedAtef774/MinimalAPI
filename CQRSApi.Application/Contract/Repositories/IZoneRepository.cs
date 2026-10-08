using CQRSApi.Domain.Entities.Zones;

namespace CQRSApi.Application.Contract.Repositories;

public interface IZoneRepository {

    Task<List<Zone>> GetAllZonesAsync();

}
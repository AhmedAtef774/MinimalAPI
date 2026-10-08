using CQRSApi.Application.DTOs;

public interface IZoneService {
    Task<List<ZoneDto>> GetZonesAsync();
}
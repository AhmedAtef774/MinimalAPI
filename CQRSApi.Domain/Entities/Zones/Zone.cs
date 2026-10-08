namespace CQRSApi.Domain.Entities.Zones;

public class Zone : BaseEntity<int> 
{
    public string Name { get; set; } = string.Empty;
}
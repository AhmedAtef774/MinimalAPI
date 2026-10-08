namespace CQRSApi.Domain.Entities.Zones;

public class Region : BaseEntity<int> {
    public string Name { get; set; } = string.Empty;

    public int ZoneId {get;set;}
}
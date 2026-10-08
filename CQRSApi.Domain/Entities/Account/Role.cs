namespace CQRSApi.Domain.Entities.Account;

public class Role : BaseEntity<Guid> 
{
    public string Name { get; set; } = string.Empty;
}
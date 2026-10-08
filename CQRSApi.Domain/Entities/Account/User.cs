using CQRSApi.Domain.Entities;

namespace CQRSApi.Domain.Entities.Account;

public class User : BaseEntity<Guid> {
    public string Storename { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public int ZoneId {get;set;}

    public int PaymentTypeId {get;set;}

    public int RegionId {get;set;}

    public bool IsEmailConfirmed {get;set;} = false;

}
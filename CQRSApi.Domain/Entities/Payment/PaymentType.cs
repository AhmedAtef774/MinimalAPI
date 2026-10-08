namespace CQRSApi.Domain.Entities.Payment;

public class PaymentType : BaseEntity<int> {
    public string Name { get; set; } = string.Empty;
}
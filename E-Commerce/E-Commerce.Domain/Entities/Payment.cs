using E_Commerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Payment : BaseEntity
{
    public string PaymentType { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
    public float TotalValue { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime DtPayment { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
}

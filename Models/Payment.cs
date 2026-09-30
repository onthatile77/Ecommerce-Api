using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class Payment
{
    public Guid Id { get; set; }

    [Required]
    public Guid OrderId { get; set; }

    [ForeignKey(nameof(OrderId))]
    public Order Order { get; set; } = null!;

    [Required]
    public string Provider { get; set; } = null!;

    [Required]
    public string ProviderPaymentId { get; set; } = null!;

    [Required]
    public PaymentStatus Status { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }
}
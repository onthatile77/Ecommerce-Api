using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Api.Models;

public class Address
{
    public Guid Id { get; set; }

    [Required]
    public Guid CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;

    [Required]
    public string Label { get; set; } = null!;

    [Required]
    public string Line1 { get; set; } = null!;

    public string? Line2 { get; set; }

    [Required]
    public string City { get; set; } = null!;

    [Required]
    public string State { get; set; } = null!;

    [Required]
    public string PostalCode { get; set; } = null!;

    [Required]
    public string Country { get; set; } = null!;

    public bool IsDefault { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
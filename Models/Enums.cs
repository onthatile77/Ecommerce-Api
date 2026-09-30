namespace Ecommerce_Api.Models;

public enum CartStatus
{
    Active,
    ConvertedToOrder,
    Abandoned
}

public enum OrderStatus
{
    Pending,
    PaymentConfirmed,
    Processing,
    Shipped,
    Delivered,
    Cancelled,
    Refunded
}

public enum PaymentStatus
{
    Pending,
    Succeeded,
    Failed,
    Refunded
}
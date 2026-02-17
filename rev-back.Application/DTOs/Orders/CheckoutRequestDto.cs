namespace rev_back.Application.DTOs.Orders;

public record CheckoutRequestDto(
    string ShippingAddress,
    string ContactPhone,
    string PaymentMethod);

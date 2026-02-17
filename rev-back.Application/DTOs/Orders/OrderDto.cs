namespace rev_back.Application.DTOs.Orders;

public record OrderDto(
    Guid Id,
    Guid UserId,
    DateTime CreatedAtUtc,
    string Status,
    decimal TotalAmount,
    IReadOnlyCollection<OrderItemDto> Items);

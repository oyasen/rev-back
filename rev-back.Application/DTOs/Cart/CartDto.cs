namespace rev_back.Application.DTOs.Cart;

public record CartDto(
    Guid Id,
    Guid UserId,
    IReadOnlyCollection<CartItemDto> Items,
    decimal TotalAmount);

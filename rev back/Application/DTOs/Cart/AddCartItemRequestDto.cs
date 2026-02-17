namespace rev_back.Application.DTOs.Cart;

public record AddCartItemRequestDto(
    Guid ProductId,
    int Quantity);

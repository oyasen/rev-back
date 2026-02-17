namespace rev_back.Application.DTOs.Products;

public record CreateProductRequestDto(
    string Name,
    string? Description,
    decimal Price,
    int StockQuantity,
    string? ImageUrl,
    Guid CategoryId);

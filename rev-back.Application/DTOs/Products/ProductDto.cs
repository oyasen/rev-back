namespace rev_back.Application.DTOs.Products;

public record ProductDto(
    Guid Id,
    string Name,
    string? Description,
    decimal Price,
    int StockQuantity,
    string? ImageUrl,
    Guid CategoryId,
    string CategoryName);

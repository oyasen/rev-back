namespace rev_back.Application.DTOs.Products;

public record ProductSearchRequestDto(
    string? Query,
    Guid? CategoryId,
    decimal? MinPrice,
    decimal? MaxPrice,
    int Page = 1,
    int PageSize = 20);

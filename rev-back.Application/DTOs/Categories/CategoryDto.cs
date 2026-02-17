namespace rev_back.Application.DTOs.Categories;

public record CategoryDto(
    Guid Id,
    string Name,
    string? Description);

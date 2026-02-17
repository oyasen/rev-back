namespace rev_back.Application.DTOs.Categories;

public record CreateCategoryRequestDto(
    string Name,
    string? Description);

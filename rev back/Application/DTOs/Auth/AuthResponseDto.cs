namespace rev_back.Application.DTOs.Auth;

public record AuthResponseDto(
    Guid UserId,
    string FullName,
    string Email,
    string Role,
    string Token,
    DateTime ExpiresAtUtc);

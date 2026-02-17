namespace rev_back.Application.DTOs.Auth;

public record LoginRequestDto(
    string Email,
    string Password);

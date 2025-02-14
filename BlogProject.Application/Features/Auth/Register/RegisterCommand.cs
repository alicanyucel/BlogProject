using MediatR;


namespace BlogProject.Application.Features.Auth.Register
{
    public sealed record RegisterCommand(
     string FirstName,
     string Lastname,
     string Email,
     string UserName,
     string Password,
     string PhoneNumber,
     Guid RefreshToken,
     DateTime RefreshTokenExpires
    ) : IRequest<Unit>;
}

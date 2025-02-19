

using BlogProject.Application.Features.Auth.Login;
using BlogProject.Domain.Entities;

namespace BlogProject.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}

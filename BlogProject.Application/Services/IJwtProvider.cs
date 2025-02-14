

using BlogProject.Application.Features.Auth.Login;
using BlogProject.Domain;

namespace BlogProject.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}

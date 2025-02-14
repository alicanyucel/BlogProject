
using MediatR;

namespace BlogProject.Domain.Event.Users
{
    public sealed class UserDomainEvent : INotification
    {
        public AppUser AppUser { get; }

        public UserDomainEvent(AppUser appUser)
        {
            AppUser = appUser;
        }
    }
}

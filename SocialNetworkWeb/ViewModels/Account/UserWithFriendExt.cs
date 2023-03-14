using SocialNetworkWeb.Models.Users;

namespace SocialNetworkWeb.ViewModels.Account
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
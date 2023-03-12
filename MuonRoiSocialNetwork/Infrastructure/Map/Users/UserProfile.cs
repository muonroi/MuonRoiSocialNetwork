using AutoMapper;
using MuonRoi.Social_Network.Users;
using MuonRoiSocialNetwork.Application.Commands.Users;
using MuonRoiSocialNetwork.Common.Models.Users;

namespace MuonRoiSocialNetwork.Infrastructure.Map.Users
{
    /// <summary>
    /// Register map
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UserProfile()
        {
            CreateMap<AppUser, UserModel>();
            CreateMap<CreateUserCommand, AppUser>();
        }
    }
}

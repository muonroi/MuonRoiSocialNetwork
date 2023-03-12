using MuonRoi.Social_Network.Users;

namespace MuonRoiSocialNetwork.Domains.Interfaces
{
    /// <summary>
    /// UserRepository Interface
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Confirmed Email
        /// </summary>
        /// <param name="checkUser"></param>
        /// <returns></returns>
        Task<int> ConfirmedEmail(AppUser checkUser);

        /// <summary>
        /// Create new user no role
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        Task<int> CreateNewUserAsync(AppUser newUser);

        /// <summary>
        /// Check user is exist? by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Task<bool> ExistUserByUsernameAsync(string username);
        /// <summary>
        /// Get user by guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<AppUser> GetByGuidAsync(Guid id);
        /// <summary>
        /// Get user by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Task<AppUser> GetByUsernameAsync(string username);
        /// <summary>
        /// Update info user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<int> UpdateUserAsync(AppUser user);
    }
}

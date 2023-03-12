using MuonRoi.Social_Network.Users;
using Microsoft.EntityFrameworkCore;
using MuonRoiSocialNetwork.Domains.Interfaces;

namespace MuonRoiSocialNetwork.Infrastructure.Repositories
{
    /// <summary>
    /// Handler user
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly MuonRoiSocialNetworkDbContext _dbcontext;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        public UserRepository(MuonRoiSocialNetworkDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        /// <summary>
        /// Handle check user is exist? by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<bool> ExistUserByUsernameAsync(string username)
        {
            return await _dbcontext.Users.AsNoTracking()
                 .AnyAsync(x => x.UserName.Equals(username))
                 .ConfigureAwait(false);
        }
        /// <summary>
        /// Handle create new user no role
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public async Task<int> CreateNewUserAsync(AppUser newUser)
        {
            _dbcontext.Add(newUser);
            return await _dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// Handle get user by guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AppUser> GetByGuidAsync(Guid id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _dbcontext.Users != null ? await _dbcontext.Users
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id.Equals(id)) : null;
#pragma warning restore CS8603 // Possible null reference return.
        }
        /// <summary>
        /// Handle confirmed email
        /// </summary>
        /// <param name="checkUser"></param>
        /// <returns></returns>
        public async Task<int> ConfirmedEmail(AppUser checkUser)
        {
            _dbcontext.Users.Update(checkUser);
            return await _dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// handle get user by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<AppUser> GetByUsernameAsync(string username)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _dbcontext.Users != null ? await _dbcontext.Users
                       .AsNoTracking()
                       .FirstOrDefaultAsync(x => x.UserName.Equals(username)) : null;
#pragma warning restore CS8603 // Possible null reference return.
        }
        /// <summary>
        /// Handle update info user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<int> UpdateUserAsync(AppUser user)
        {
            _dbcontext.Users.Update(user);
            return await _dbcontext.SaveChangesAsync();
        }
    }
}

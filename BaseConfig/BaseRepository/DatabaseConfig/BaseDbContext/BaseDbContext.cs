using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseConfig.BaseRepository.DatabaseConfig.BaseDbContext
{
    public class BaseDbContext : IdentityDbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        { }
    }
}

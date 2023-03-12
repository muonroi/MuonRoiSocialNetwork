using MuonRoi.Social_Network.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MuonRoiSocialNetwork.Infrastructure.EFConfigs.Users
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable(nameof(AppUser));
        }
    }
}

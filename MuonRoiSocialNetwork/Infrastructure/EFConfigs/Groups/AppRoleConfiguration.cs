using MuonRoi.Social_Network.Roles;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MuonRoiSocialNetwork.Domains.DomainObjects.Groups;

namespace MuonRoiSocialNetwork.Infrastructure.EFConfigs.Groups
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable(nameof(AppRole));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsUnicode();
        }
    }
}

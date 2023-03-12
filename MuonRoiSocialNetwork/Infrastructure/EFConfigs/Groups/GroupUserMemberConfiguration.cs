using MuonRoi.Social_Network.Roles;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MuonRoi.Social_Network.Configurations.Roles
{
    public class GroupUserMemberConfiguration : IEntityTypeConfiguration<GroupUserMember>
    {
        public void Configure(EntityTypeBuilder<GroupUserMember> builder)
        {
            builder.ToTable(nameof(GroupUserMember));
            builder.HasKey(x => new { x.AppUserKey, x.AppRoleKey });
            builder.HasOne(x => x.UserMember)
                .WithMany(x => x.GroupUserMember)
                .HasForeignKey(x => x.AppUserKey);

            builder.HasOne(x => x.AppRole)
                .WithMany(x => x.GroupUserMember)
                .HasForeignKey(x => x.AppRoleKey);
        }
    }
}

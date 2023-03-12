using MuonRoi.Social_Network.Storys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MuonRoi.Social_Network.Configurations.Storys
{
    public class StoryNotificationConfiguration : IEntityTypeConfiguration<StoryNotifications>
    {
        public void Configure(EntityTypeBuilder<StoryNotifications> builder)
        {
            builder.ToTable(nameof(StoryNotifications));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Story).WithMany(x => x.StoryNotifications).HasForeignKey(x => x.StoryGuid);
            builder.HasOne(x => x.UserMember).WithMany(x => x.StoryNotifications).HasForeignKey(x => x.UserGuid);
        }
    }
}

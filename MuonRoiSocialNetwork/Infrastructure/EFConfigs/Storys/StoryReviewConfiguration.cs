using MuonRoi.Social_Network.Storys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MuonRoi.Social_Network.Configurations.Storys
{
    public class StoryReviewConfiguration : IEntityTypeConfiguration<StoryReview>
    {
        public void Configure(EntityTypeBuilder<StoryReview> builder)
        {
            builder.ToTable(nameof(StoryReview));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Content);
            builder.HasOne(x => x.UserMember).WithMany(x => x.StoryReview).HasForeignKey(x => x.UserGuid);
        }
    }
}
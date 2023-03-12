using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MuonRoi.Social_Network.Tags;

namespace MuonRoi.Social_Network.Configurations.Tags
{
    public class TagInStoryConfiguration : IEntityTypeConfiguration<TagInStory>
    {
        public void Configure(EntityTypeBuilder<TagInStory> builder)
        {
            builder.ToTable(nameof(TagInStory));
            builder.HasKey(x => new { x.StoryGuid, x.TagId });
            builder.HasOne(x => x.Tag)
                .WithMany(x => x.TagInStory)
                .HasForeignKey(x => x.TagId);

            builder.HasOne(x => x.Story)
                .WithMany(x => x.TagInStory)
                .HasForeignKey(x => x.StoryGuid);
        }
    }
}

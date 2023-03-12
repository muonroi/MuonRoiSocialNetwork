using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MuonRoi.Social_Network.Tags;

namespace MuonRoi.Social_Network.Configurations.Tags
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(nameof(Tag));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}

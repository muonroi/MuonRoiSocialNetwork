using MuonRoi.Social_Network.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MuonRoi.Social_Network.Configurations.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}

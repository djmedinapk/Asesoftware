using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logic.Data.Configuration
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.BirthDay).IsRequired().HasMaxLength(50);
        }
    }
}

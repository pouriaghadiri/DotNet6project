using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "07206d0a-9468-4065-8b74-2ee263ba15b8",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR",
                    },
                    new IdentityRole
                    {
                        Id = "a93b57f3-beb2-4452-b4cd-50c26292585f",
                        Name = "User",
                        NormalizedName = "USER",
                    }
                );
        }
    }
}
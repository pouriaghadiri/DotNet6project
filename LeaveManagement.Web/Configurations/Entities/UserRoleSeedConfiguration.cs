using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = "32715269-feb2-463d-9ebd-59156d08fd9f",
                        RoleId = "07206d0a-9468-4065-8b74-2ee263ba15b8"
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "70917d7f-2e24-42ab-8e16-a0d49804831d",
                        RoleId = "a93b57f3-beb2-4452-b4cd-50c26292585f"
                    }
                );
        }
    }
}
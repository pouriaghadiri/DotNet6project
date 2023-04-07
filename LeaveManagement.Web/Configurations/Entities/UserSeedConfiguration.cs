using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                    new Employee
                    {
                        Id = "32715269-feb2-463d-9ebd-59156d08fd9f",
                        FirstName = "System",
                        LastName = "Admin",
                        Email = "po@1.com",
                        NormalizedEmail = "PO@1.COM",
                        UserName = "po@1.com",
                        NormalizedUserName = "PO@1.COM",
                        PasswordHash = hasher.HashPassword(null , "P@ssword1"),
                        EmailConfirmed = true
                    },
                    new Employee
                    {
                        Id = "70917d7f-2e24-42ab-8e16-a0d49804831d",
                        FirstName = "System",
                        LastName = "User",
                        Email = "po@2.com",
                        NormalizedEmail = "PO@2.COM",
                        UserName = "po@2.com",
                        NormalizedUserName = "PO@2.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    }
                );
        }
    }
}
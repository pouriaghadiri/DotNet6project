using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07206d0a-9468-4065-8b74-2ee263ba15b8", "bb9d7aae-787b-495b-bdce-d1945d57ec0a", "Administrator", "ADMINISTRATOR" },
                    { "a93b57f3-beb2-4452-b4cd-50c26292585f", "9cb27a16-140f-4a17-96ef-756b2651c64b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32715269-feb2-463d-9ebd-59156d08fd9f", 0, "c2fadf89-4bd7-4319-8b7b-b5fb0bd77f66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "po@1.com", false, "System", "Admin", false, null, "PO@1.COM", "PO@1.COM", "AQAAAAEAACcQAAAAEABrkA8Z7ok6uGOOH7YP1uiK51nDjfPSW+fra63cjjpnIUh7VnWf33ZVmYcKCTj86A==", null, false, "d863c9e7-32b5-46a5-82b0-0f7c6a390f31", null, false, "po@1.com" },
                    { "70917d7f-2e24-42ab-8e16-a0d49804831d", 0, "1d949530-f8ba-4e04-97a8-d1bd8d9ad7bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "po@2.com", false, "System", "User", false, null, "PO@2.COM", "PO@2.COM", "AQAAAAEAACcQAAAAEJzwXTyz3RTR7bdE4MHosEo5dynOR56Qfp27JLwK6Xpqf317Zyv5q8EdIIfLyDWqZg==", null, false, "ff003ac5-93ad-4686-95f2-8ce63687fab8", null, false, "po@2.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07206d0a-9468-4065-8b74-2ee263ba15b8", "32715269-feb2-463d-9ebd-59156d08fd9f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a93b57f3-beb2-4452-b4cd-50c26292585f", "70917d7f-2e24-42ab-8e16-a0d49804831d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07206d0a-9468-4065-8b74-2ee263ba15b8", "32715269-feb2-463d-9ebd-59156d08fd9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a93b57f3-beb2-4452-b4cd-50c26292585f", "70917d7f-2e24-42ab-8e16-a0d49804831d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07206d0a-9468-4065-8b74-2ee263ba15b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93b57f3-beb2-4452-b4cd-50c26292585f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32715269-feb2-463d-9ebd-59156d08fd9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70917d7f-2e24-42ab-8e16-a0d49804831d");
        }
    }
}

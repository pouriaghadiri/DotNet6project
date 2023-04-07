using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07206d0a-9468-4065-8b74-2ee263ba15b8",
                column: "ConcurrencyStamp",
                value: "3637b3a5-a01b-492a-a1eb-df2dbe383af7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93b57f3-beb2-4452-b4cd-50c26292585f",
                column: "ConcurrencyStamp",
                value: "bdda3e41-61d9-4682-bf4c-005160eb2994");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32715269-feb2-463d-9ebd-59156d08fd9f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca40d8e2-7648-412b-974c-470cba68562d", true, "AQAAAAEAACcQAAAAEEysgJyW727xIsHtU7yjIH8W725Ti6+XhAbeASEezKwTKBTG6wA2ArDgW8EAzPMJGQ==", "c357aa7f-2658-4fdf-b685-e5597e427ffb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70917d7f-2e24-42ab-8e16-a0d49804831d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ed0102-c62f-465a-bca7-c4869cfa7f0e", true, "AQAAAAEAACcQAAAAEEcTp26uoahXIpLHg6MosM+pcmdWx3/e2liPH0ZQDTf8uFcaUE8p9qA9ui0j2OSwdA==", "88cb1db7-8e04-4355-a9eb-72b649475a9d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07206d0a-9468-4065-8b74-2ee263ba15b8",
                column: "ConcurrencyStamp",
                value: "bb9d7aae-787b-495b-bdce-d1945d57ec0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93b57f3-beb2-4452-b4cd-50c26292585f",
                column: "ConcurrencyStamp",
                value: "9cb27a16-140f-4a17-96ef-756b2651c64b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32715269-feb2-463d-9ebd-59156d08fd9f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2fadf89-4bd7-4319-8b7b-b5fb0bd77f66", false, "AQAAAAEAACcQAAAAEABrkA8Z7ok6uGOOH7YP1uiK51nDjfPSW+fra63cjjpnIUh7VnWf33ZVmYcKCTj86A==", "d863c9e7-32b5-46a5-82b0-0f7c6a390f31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70917d7f-2e24-42ab-8e16-a0d49804831d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d949530-f8ba-4e04-97a8-d1bd8d9ad7bd", false, "AQAAAAEAACcQAAAAEJzwXTyz3RTR7bdE4MHosEo5dynOR56Qfp27JLwK6Xpqf317Zyv5q8EdIIfLyDWqZg==", "ff003ac5-93ad-4686-95f2-8ce63687fab8" });
        }
    }
}

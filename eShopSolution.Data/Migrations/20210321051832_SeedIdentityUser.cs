using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 20, 22, 18, 30, 655, DateTimeKind.Local).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 20, 19, 22, 10, 252, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"), "5deab409-e1d5-413a-845a-ac7e97a882be", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf"), 0, "654a10eb-92dd-4680-bdf4-ee28707f36cd", new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc@gmail.com", true, "Eric", "T", false, null, "abc@gmail.com", "admin", "AQAAAAEAACcQAAAAECdLR0nlkIaLRQlk0cfTGQS/9tBH5eXkjaEZV2E/rSMPu1DmE9Sz7VRqxVgkM0p4JQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"), new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 20, 22, 18, 30, 703, DateTimeKind.Local).AddTicks(789));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"), new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf") });

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 20, 19, 22, 10, 252, DateTimeKind.Local).AddTicks(2305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 20, 22, 18, 30, 655, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 20, 19, 22, 10, 281, DateTimeKind.Local).AddTicks(4941));
        }
    }
}

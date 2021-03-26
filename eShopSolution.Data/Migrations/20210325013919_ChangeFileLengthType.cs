using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"),
                column: "ConcurrencyStamp",
                value: "3fe4fb98-1d44-48f3-a427-bb27271f186a");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b13fc800-efdf-486e-bcee-9d8498c264dd", "AQAAAAEAACcQAAAAEMToT9uSCYEN3OJoXtX/9qNCKt/piJe4zb/A5eQBVGkeglKgo5IAyNt5hrVXfWPHPA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 24, 18, 39, 17, 882, DateTimeKind.Local).AddTicks(3262));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"),
                column: "ConcurrencyStamp",
                value: "bcdc678a-30d1-476a-ad31-70433939ab84");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2a2c081-e817-48d8-a98e-846296eb07d0", "AQAAAAEAACcQAAAAEMgp2EdySm0tzeGPGpgQkGr/xkZIiBo3dbWZ8q5cUoVYsh1YkFurhT8ILX7dfBG1Jg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 23, 23, 12, 52, 24, DateTimeKind.Local).AddTicks(186));
        }
    }
}

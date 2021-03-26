using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 20, 22, 18, 30, 655, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 20, 22, 18, 30, 655, DateTimeKind.Local).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9a4e043-d03b-484a-97ee-4a60806698cc"),
                column: "ConcurrencyStamp",
                value: "5deab409-e1d5-413a-845a-ac7e97a882be");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4c4d5af5-cf2d-4e11-a099-93da905baacf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "654a10eb-92dd-4680-bdf4-ee28707f36cd", "AQAAAAEAACcQAAAAECdLR0nlkIaLRQlk0cfTGQS/9tBH5eXkjaEZV2E/rSMPu1DmE9Sz7VRqxVgkM0p4JQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 3, 20, 22, 18, 30, 703, DateTimeKind.Local).AddTicks(789));
        }
    }
}

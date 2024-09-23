using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETicaretApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4666405-3492-42cf-8e2f-b9e0e0b3c95c", null, "Admin", "ADMIN" },
                    { "ac87bbc8-e227-43fe-99ec-f3db69e37c5c", null, "User", "USER" },
                    { "ed408a26-0623-4b3b-8059-3dc54f4b9ccd", null, "Editor", "EDITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4666405-3492-42cf-8e2f-b9e0e0b3c95c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac87bbc8-e227-43fe-99ec-f3db69e37c5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed408a26-0623-4b3b-8059-3dc54f4b9ccd");
        }
    }
}

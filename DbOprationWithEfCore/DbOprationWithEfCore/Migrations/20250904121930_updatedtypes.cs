using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbOprationWithEfCore.Migrations
{
    /// <inheritdoc />
    public partial class updatedtypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CurrencyType");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CurrencyType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CurrencyType",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Indian INR", "INR" },
                    { 2, "Dollar", "Dollar" },
                    { 3, "Euro", "Euro" },
                    { 4, "Dinar", "Dinar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrencyType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CurrencyType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrencyType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CurrencyType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CurrencyType");

            migrationBuilder.AddColumn<int>(
                name: "Currency",
                table: "CurrencyType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

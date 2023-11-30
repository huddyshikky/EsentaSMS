using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EsentaSMS.Migrations
{
    /// <inheritdoc />
    public partial class Seedorganisations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "Id", "Address", "City", "County", "Email", "Logo", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "P.o Box 1950 - 30200 Kitale", null, null, "infor@esentacomputerlab.co.ke", "esenta.jpg", "Esenta Computer Lab", "0725 319 665" },
                    { 2, "P.o Box 1950 - 30200 Kitale", null, null, "infor@esentacomputerlab.co.ke", "esenta.jpg", "Esenta Computer Lab", "0725 319 665" },
                    { 3, "P.o Box 1950 - 30200 Kitale", null, null, "infor@esentacomputerlab.co.ke", "esenta.jpg", "Esenta Computer Lab", "0725 319 665" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

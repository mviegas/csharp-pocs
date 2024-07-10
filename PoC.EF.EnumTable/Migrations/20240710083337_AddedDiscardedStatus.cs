using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoC.EF.EnumTable.Migrations
{
    /// <inheritdoc />
    public partial class AddedDiscardedStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Description" },
                values: new object[] { 3, "Discarded" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

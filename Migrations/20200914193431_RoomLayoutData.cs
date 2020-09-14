using Microsoft.EntityFrameworkCore.Migrations;

namespace ASyncInn.Migrations
{
    public partial class RoomLayoutData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Layout",
                value: "0br");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Layout",
                value: "1br");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Layout",
                value: "2br");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Layout",
                value: "0br.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Layout",
                value: "1br.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Layout",
                value: "2br.");
        }
    }
}

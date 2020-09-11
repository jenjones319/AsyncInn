using Microsoft.EntityFrameworkCore.Migrations;

namespace ASyncInn.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelAddress",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "HotelCity",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "HotelName",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "HotelState",
                table: "Hotels");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Hotels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Layout = table.Column<string>(nullable: true),
                    Amenities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "AC" },
                    { 2L, "Wireless" },
                    { 3L, "Coffee Maker" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1L, "Iowa City", "Async Inn", "319 - 541 - 7504", "Iowa", "515 W. Burlington St" },
                    { 2L, "Moline", "Async Hotel", "630 - 772 - 1411", "Illinois", "1216 Aurora Ln" },
                    { 3L, "St. Paul", "Async Spa", "612 - 424 - 2468", "Minnesota", "1984 Wasatch Pl" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Amenities", "Layout", "Name" },
                values: new object[,]
                {
                    { 1L, null, "0br.", "Studio" },
                    { 2L, null, "1br.", "OneBdr" },
                    { 3L, null, "2br.", "TwoBdr" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Hotels");

            migrationBuilder.AddColumn<string>(
                name: "HotelAddress",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HotelCity",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HotelName",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HotelState",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

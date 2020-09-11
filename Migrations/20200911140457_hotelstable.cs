using Microsoft.EntityFrameworkCore.Migrations;

namespace ASyncInn.Migrations
{
    public partial class hotelstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(nullable: true),
                    HotelAddress = table.Column<string>(nullable: true),
                    HotelCity = table.Column<string>(nullable: true),
                    HotelState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}

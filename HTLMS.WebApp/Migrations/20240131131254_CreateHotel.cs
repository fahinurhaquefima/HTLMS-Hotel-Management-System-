using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTLMS.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    HotelDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HotelType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HotelAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    HotelCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HotelPhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}

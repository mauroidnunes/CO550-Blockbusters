using Microsoft.EntityFrameworkCore.Migrations;

namespace blockbusters.Data.Migrations
{
    public partial class AddmovireTrialer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTrailer",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieTrailer",
                table: "Movies");
        }
    }
}

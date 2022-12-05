using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace skillzshop.Migrations
{
    public partial class sellernamerating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Skills",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerName",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SellerName",
                table: "Skills");
        }
    }
}

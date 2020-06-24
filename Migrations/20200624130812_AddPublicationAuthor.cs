using Microsoft.EntityFrameworkCore.Migrations;

namespace PublicationSystem.Migrations
{
    public partial class AddPublicationAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Publication",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Publication");
        }
    }
}

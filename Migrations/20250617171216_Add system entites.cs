using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartChef_API.Migrations
{
    /// <inheritdoc />
    public partial class Addsystementites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Recipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Recipe",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

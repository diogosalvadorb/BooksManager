using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksManager.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActiveAllEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Books");
        }
    }
}

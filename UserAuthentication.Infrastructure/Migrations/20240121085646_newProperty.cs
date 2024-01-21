using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserAuthentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentOrEmployee",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentOrEmployee",
                table: "Users");
        }
    }
}

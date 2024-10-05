using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fitness.Migrations
{
    /// <inheritdoc />
    public partial class OpeningHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Gyms",
                type: "jsonb",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Gyms_Slug",
                table: "Gyms",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Gyms_Slug",
                table: "Gyms");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Gyms");
        }
    }
}

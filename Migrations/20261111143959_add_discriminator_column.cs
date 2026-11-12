using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart_Asset_Tracking_System.Migrations
{
    /// <inheritdoc />
    public partial class add_discriminator_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssetType",
                table: "Assets",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetType",
                table: "Assets");
        }
    }
}

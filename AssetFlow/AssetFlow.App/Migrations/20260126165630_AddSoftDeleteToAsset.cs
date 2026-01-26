using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetFlow.App.Migrations
{
    public partial class AddSoftDeleteToAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Assets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Assets");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrariryForm.Migrations
{
    public partial class updatemodelUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fin",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeriyaNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SeriyaNumber",
                table: "Users");
        }
    }
}

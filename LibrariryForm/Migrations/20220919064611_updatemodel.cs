using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrariryForm.Migrations
{
    public partial class updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobPlace",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SurName",
                table: "Users",
                newName: "WorkInfo");

            migrationBuilder.RenameColumn(
                name: "Possesion",
                table: "Users",
                newName: "PrivateInfo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Adress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkInfo",
                table: "Users",
                newName: "SurName");

            migrationBuilder.RenameColumn(
                name: "PrivateInfo",
                table: "Users",
                newName: "Possesion");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Users",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobPlace",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

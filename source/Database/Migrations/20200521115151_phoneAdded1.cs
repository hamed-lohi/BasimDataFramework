using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Database.Migrations
{
    public partial class phoneAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "User",
                table: "Users",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "User",
                table: "Users",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "User",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "User",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);
        }
    }
}

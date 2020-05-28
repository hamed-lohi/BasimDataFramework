using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Database.Migrations
{
    public partial class baseDomainFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                schema: "User",
                table: "Users",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                schema: "User",
                table: "Users",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertDate",
                schema: "User",
                table: "Users",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertTime",
                schema: "User",
                table: "Users",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertUser",
                schema: "User",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateDate",
                schema: "User",
                table: "Users",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateTime",
                schema: "User",
                table: "Users",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateUser",
                schema: "User",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertDate",
                schema: "Auth",
                table: "Auths",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertTime",
                schema: "Auth",
                table: "Auths",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SInsertUser",
                schema: "Auth",
                table: "Auths",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateDate",
                schema: "Auth",
                table: "Auths",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateTime",
                schema: "Auth",
                table: "Auths",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SUpdateUser",
                schema: "Auth",
                table: "Auths",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SInsertDate",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SInsertTime",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SInsertUser",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SUpdateDate",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SUpdateTime",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SUpdateUser",
                schema: "User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SInsertDate",
                schema: "Auth",
                table: "Auths");

            migrationBuilder.DropColumn(
                name: "SInsertTime",
                schema: "Auth",
                table: "Auths");

            migrationBuilder.DropColumn(
                name: "SInsertUser",
                schema: "Auth",
                table: "Auths");

            migrationBuilder.DropColumn(
                name: "SUpdateDate",
                schema: "Auth",
                table: "Auths");

            migrationBuilder.DropColumn(
                name: "SUpdateTime",
                schema: "Auth",
                table: "Auths");

            migrationBuilder.DropColumn(
                name: "SUpdateUser",
                schema: "Auth",
                table: "Auths");
        }
    }
}

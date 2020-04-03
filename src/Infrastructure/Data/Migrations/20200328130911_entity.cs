using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.Nnn.Infrastructure.Data.Migrations
{
    public partial class entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Beautiful",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Clever",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClothingStyle",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Funny",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HairStyle",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Handsome",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Honest",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Impressive",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MakeUp",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Reliable",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sympathetic",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TalkingStyle",
                table: "Votes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beautiful",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Clever",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ClothingStyle",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Funny",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "HairStyle",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Handsome",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Honest",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Impressive",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "MakeUp",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Reliable",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Sympathetic",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "TalkingStyle",
                table: "Votes");
        }
    }
}

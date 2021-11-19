using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMvc.Data.Migrations
{
    public partial class update_activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ItemDesc",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "PrgAg",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "PrgCont",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "PrgTicket",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "TicketSysUrl",
                table: "Activities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDesc",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrgAg",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrgCont",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrgTicket",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TicketSysUrl",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

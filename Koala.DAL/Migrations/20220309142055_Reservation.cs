using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koala.DAL.Migrations
{
    public partial class Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MailAddress = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    ReservasionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservasionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPNo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}

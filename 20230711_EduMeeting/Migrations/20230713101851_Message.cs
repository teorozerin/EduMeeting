using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230711_EduMeeting.Migrations
{
    /// <inheritdoc />
    public partial class Message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUserName = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    MailAdress = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Messages = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    RecTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPNO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");
        }
    }
}

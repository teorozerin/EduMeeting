using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230711_EduMeeting.Migrations
{
    /// <inheritdoc />
    public partial class Detail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Meeting",
                type: "Text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Meeting");
        }
    }
}

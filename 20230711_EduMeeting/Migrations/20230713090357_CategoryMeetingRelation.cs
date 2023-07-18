using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230711_EduMeeting.Migrations
{
    /// <inheritdoc />
    public partial class CategoryMeetingRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Meeting",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CategoryID",
                table: "Meeting",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Category_CategoryID",
                table: "Meeting",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Category_CategoryID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_CategoryID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Meeting");
        }
    }
}

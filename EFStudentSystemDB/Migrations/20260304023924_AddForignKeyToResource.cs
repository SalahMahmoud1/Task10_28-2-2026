using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFStudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddForignKeyToResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Course_CourseId",
                table: "Resources",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Course_CourseId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_CourseId",
                table: "Resources");
        }
    }
}

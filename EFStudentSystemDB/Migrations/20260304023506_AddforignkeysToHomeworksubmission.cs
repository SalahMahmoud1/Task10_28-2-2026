using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFStudentSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddforignkeysToHomeworksubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_CourseId",
                table: "HomeworkSubmissions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Course_CourseId",
                table: "HomeworkSubmissions",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Course_CourseId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropIndex(
                name: "IX_HomeworkSubmissions_CourseId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "HomeworkSubmissions");
        }
    }
}

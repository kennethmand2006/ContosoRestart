using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contoso.Migrations
{
    /// <inheritdoc />
    public partial class model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseEnrollment");

            migrationBuilder.AddColumn<string>(
                name: "Secret",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollment",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_EnrollmentID",
                table: "Course",
                column: "EnrollmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Enrollment_EnrollmentID",
                table: "Course",
                column: "EnrollmentID",
                principalTable: "Enrollment",
                principalColumn: "EnrollmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Enrollment_EnrollmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_CourseID",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Course_EnrollmentID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Secret",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "EnrollmentID",
                table: "Course");

            migrationBuilder.CreateTable(
                name: "CourseEnrollment",
                columns: table => new
                {
                    CoursesCourseID = table.Column<int>(type: "int", nullable: false),
                    EnrollmentsEnrollmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEnrollment", x => new { x.CoursesCourseID, x.EnrollmentsEnrollmentID });
                    table.ForeignKey(
                        name: "FK_CourseEnrollment_Course_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseEnrollment_Enrollment_EnrollmentsEnrollmentID",
                        column: x => x.EnrollmentsEnrollmentID,
                        principalTable: "Enrollment",
                        principalColumn: "EnrollmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollment_EnrollmentsEnrollmentID",
                table: "CourseEnrollment",
                column: "EnrollmentsEnrollmentID");
        }
    }
}

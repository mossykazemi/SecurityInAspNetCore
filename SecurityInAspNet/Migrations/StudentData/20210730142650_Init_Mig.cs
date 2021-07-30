using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecurityInAspNet.Migrations.StudentData
{
    public partial class Init_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProfessorName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StudentUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}

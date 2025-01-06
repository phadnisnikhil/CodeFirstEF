using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstEF.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "New York", "XYZ Inc", "Developer", "Nikhil", 30000f },
                    { 2, "New York", "ABC Inc", "Manager", "Reyansh", 50000f },
                    { 3, "New Delhi", "XYZ Inc", "Consultant", "Pulakit", 20000f },
                    { 4, "New York", "XYZ Inc", "Developer", "Saurabh", 30000f },
                    { 5, "New York", "ABC Inc", "Manager", "Hemant", 50000f },
                    { 6, "New Delhi", "XYZ Inc", "Consultant", "Aarav", 20000f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

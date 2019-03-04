using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeMERP.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STP_DEPARTMENT",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STP_DEPARTMENT", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "STP_EMPLOYEE",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FatherName = table.Column<string>(maxLength: 100, nullable: true),
                    Gender = table.Column<string>(maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    MaritalStatus = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNo = table.Column<string>(maxLength: 50, nullable: true),
                    Picture = table.Column<string>(maxLength: 200, nullable: true),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STP_EMPLOYEE", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_STP_EMPLOYEE_STP_DEPARTMENT_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "STP_DEPARTMENT",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STP_ADDRESS",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STP_ADDRESS", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_STP_ADDRESS_STP_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "STP_EMPLOYEE",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STP_EMAIL",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STP_EMAIL", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_STP_EMAIL_STP_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "STP_EMPLOYEE",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STP_PHONE",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STP_PHONE", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_STP_PHONE_STP_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "STP_EMPLOYEE",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_STP_ADDRESS_EmployeeId",
                table: "STP_ADDRESS",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_STP_EMAIL_EmployeeId",
                table: "STP_EMAIL",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_STP_EMPLOYEE_DepartmentId",
                table: "STP_EMPLOYEE",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_STP_PHONE_EmployeeId",
                table: "STP_PHONE",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STP_ADDRESS");

            migrationBuilder.DropTable(
                name: "STP_EMAIL");

            migrationBuilder.DropTable(
                name: "STP_PHONE");

            migrationBuilder.DropTable(
                name: "STP_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "STP_DEPARTMENT");
        }
    }
}

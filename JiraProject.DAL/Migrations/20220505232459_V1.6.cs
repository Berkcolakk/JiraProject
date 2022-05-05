using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JiraProject.DAL.Migrations
{
    public partial class V16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CrtUserID = table.Column<int>(type: "int", nullable: false),
                    CrtUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdUserID = table.Column<int>(type: "int", nullable: false),
                    UpdUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectIssues",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectIssuespProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectUsersID = table.Column<int>(type: "int", nullable: false),
                    ProjectReporterID = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriorityID = table.Column<int>(type: "int", nullable: false),
                    LabelID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FixVersionID = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuesParentID = table.Column<int>(type: "int", nullable: false),
                    FlagID = table.Column<int>(type: "int", nullable: false),
                    IssueTypeID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    UserID1 = table.Column<int>(type: "int", nullable: true),
                    CrtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CrtUserID = table.Column<int>(type: "int", nullable: false),
                    CrtUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdUserID = table.Column<int>(type: "int", nullable: false),
                    UpdUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectIssues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectIssues_Project_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectIssues_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectIssues_User_UserID1",
                        column: x => x.UserID1,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: true),
                    CrtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CrtUserID = table.Column<int>(type: "int", nullable: false),
                    CrtUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdUserID = table.Column<int>(type: "int", nullable: false),
                    UpdUserIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Project_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectUser_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_ProjectsID",
                table: "ProjectIssues",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_UserID",
                table: "ProjectIssues",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_UserID1",
                table: "ProjectIssues",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectsID",
                table: "ProjectUser",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UserID",
                table: "ProjectUser",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectIssues");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "ID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "Name", "RegistrationNumber", "Type", "UpdDate", "UpdUserID", "UpdUserIP" },
                values: new object[] { 1, new DateTime(2022, 5, 6, 2, 21, 20, 265, DateTimeKind.Local).AddTicks(1717), 0, "0", "Seeding-Data", true, "DESKTOP-0000", "INTRANET Yazılım Teknolojileri", "0", "1", new DateTime(2022, 5, 6, 2, 21, 20, 266, DateTimeKind.Local).AddTicks(1535), 0, "0" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "MenuID", "Name", "UpdDate", "UpdUserID", "UpdUserIP" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 6, 2, 21, 20, 267, DateTimeKind.Local).AddTicks(5493), 0, "0", "TEST", true, "DESKTOP-0000", null, "Yazılım Geliştirici", new DateTime(2022, 5, 6, 2, 21, 20, 267, DateTimeKind.Local).AddTicks(5501), 0, "0" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "DepartmentName", "Email", "IsActive", "JobName", "MachineName", "OrganizationName", "Password", "Phone", "UpdDate", "UpdUserID", "UpdUserIP", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(1696), 0, "0", null, "berkcolak4@gmail.com", true, null, "DESKTOP-0000", null, "123456", "5434203403", new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(1705), 0, "0", "Berk Çolak" },
                    { 2, 1, new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(2743), 0, "0", null, "test@test.com.tr", true, null, "DESKTOP-0000", null, "123456", "123456", new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(2749), 0, "0", "Test Test" },
                    { 3, 1, new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(2752), 0, "0", null, "test2@test.com.tr", true, null, "DESKTOP-0000", null, "123456", "123456", new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(2754), 0, "0", "Test Test" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "RoleID", "RolesID", "StartDate", "UpdDate", "UpdUserID", "UpdUserIP", "UserID" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(6194), 0, "0", "TEST", true, "DESKTOP-0000", 1, null, new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(7068), new DateTime(2022, 5, 6, 2, 21, 20, 268, DateTimeKind.Local).AddTicks(6202), 0, "0", 1 });
        }
    }
}

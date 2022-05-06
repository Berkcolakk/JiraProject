using Microsoft.EntityFrameworkCore.Migrations;

namespace JiraProject.DAL.Migrations
{
    public partial class V19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_Projects_ProjectIssuespProjectID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Company_CompanyID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Projects_ProjectID",
                table: "ProjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CompanyID",
                table: "Project",
                newName: "IX_Project_CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Company_CompanyID",
                table: "Project",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_Project_ProjectIssuespProjectID",
                table: "ProjectIssues",
                column: "ProjectIssuespProjectID",
                principalTable: "Project",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_ProjectID",
                table: "ProjectUser",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Company_CompanyID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_Project_ProjectIssuespProjectID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_ProjectID",
                table: "ProjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CompanyID",
                table: "Projects",
                newName: "IX_Projects_CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_Projects_ProjectIssuespProjectID",
                table: "ProjectIssues",
                column: "ProjectIssuespProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Company_CompanyID",
                table: "Projects",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Projects_ProjectID",
                table: "ProjectUser",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

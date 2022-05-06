using Microsoft.EntityFrameworkCore.Migrations;

namespace JiraProject.DAL.Migrations
{
    public partial class V18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Roles_RolesID",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_Project_ProjectsID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_ProjectsID",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Menu_MenuID",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RolesID",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_RolesID",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_Roles_MenuID",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_ProjectsID",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_ProjectsID",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_RolesID",
                table: "MenuRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RolesID",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "MenuID",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ProjectsID",
                table: "ProjectUser");

            migrationBuilder.DropColumn(
                name: "ProjectsID",
                table: "ProjectIssues");

            migrationBuilder.DropColumn(
                name: "RolesID",
                table: "MenuRole");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleID",
                table: "UserRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectID",
                table: "ProjectUser",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_ProjectIssuespProjectID",
                table: "ProjectIssues",
                column: "ProjectIssuespProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MenuID",
                table: "MenuRole",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_UserRoleID",
                table: "MenuRole",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyID",
                table: "Projects",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Menu_MenuID",
                table: "MenuRole",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Roles_UserRoleID",
                table: "MenuRole",
                column: "UserRoleID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RoleID",
                table: "UserRole",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Menu_MenuID",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Roles_UserRoleID",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_Projects_ProjectIssuespProjectID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Company_CompanyID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Projects_ProjectID",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RoleID",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_RoleID",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_ProjectID",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_ProjectIssuespProjectID",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_MenuID",
                table: "MenuRole");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_UserRoleID",
                table: "MenuRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CompanyID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.AddColumn<int>(
                name: "RolesID",
                table: "UserRole",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuID",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectsID",
                table: "ProjectUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectsID",
                table: "ProjectIssues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolesID",
                table: "MenuRole",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RolesID",
                table: "UserRole",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_MenuID",
                table: "Roles",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectsID",
                table: "ProjectUser",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_ProjectsID",
                table: "ProjectIssues",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RolesID",
                table: "MenuRole",
                column: "RolesID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Roles_RolesID",
                table: "MenuRole",
                column: "RolesID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_Project_ProjectsID",
                table: "ProjectIssues",
                column: "ProjectsID",
                principalTable: "Project",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_ProjectsID",
                table: "ProjectUser",
                column: "ProjectsID",
                principalTable: "Project",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Menu_MenuID",
                table: "Roles",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RolesID",
                table: "UserRole",
                column: "RolesID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

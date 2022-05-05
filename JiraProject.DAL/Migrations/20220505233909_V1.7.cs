using Microsoft.EntityFrameworkCore.Migrations;

namespace JiraProject.DAL.Migrations
{
    public partial class V17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_User_UserID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_User_UserID1",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_UserID",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_UserID1",
                table: "ProjectIssues");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ProjectIssues");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "ProjectIssues");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_ProjectReporterID",
                table: "ProjectIssues",
                column: "ProjectReporterID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_ProjectUsersID",
                table: "ProjectIssues",
                column: "ProjectUsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_User_ProjectReporterID",
                table: "ProjectIssues",
                column: "ProjectReporterID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_User_ProjectUsersID",
                table: "ProjectIssues",
                column: "ProjectUsersID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_User_ProjectReporterID",
                table: "ProjectIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectIssues_User_ProjectUsersID",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_ProjectReporterID",
                table: "ProjectIssues");

            migrationBuilder.DropIndex(
                name: "IX_ProjectIssues_ProjectUsersID",
                table: "ProjectIssues");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "ProjectIssues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "ProjectIssues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_UserID",
                table: "ProjectIssues",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIssues_UserID1",
                table: "ProjectIssues",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_User_UserID",
                table: "ProjectIssues",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectIssues_User_UserID1",
                table: "ProjectIssues",
                column: "UserID1",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

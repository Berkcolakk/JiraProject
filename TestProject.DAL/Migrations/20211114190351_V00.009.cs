using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TestProject.DAL.Migrations
{
    public partial class V00009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Company_CompanyID1",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Company_CompanyID1",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Company_CompanyID1",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_CompanyID1",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_User_CompanyID1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CompanyID1",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CompanyID1",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CompanyID1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CompanyID1",
                table: "Roles");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Menu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menu_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    UserRoleID = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_MenuRole", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuRole_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuRole_UserRole_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CompanyID",
                table: "UserRole",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyID",
                table: "User",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CompanyID",
                table: "Roles",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CompanyID",
                table: "Menu",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MenuID",
                table: "MenuRole",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_UserRoleID",
                table: "MenuRole",
                column: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Company_CompanyID",
                table: "Roles",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Company_CompanyID",
                table: "User",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Company_CompanyID",
                table: "UserRole",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Company_CompanyID",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Company_CompanyID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Company_CompanyID",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_CompanyID",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_User_CompanyID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CompanyID",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyID",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID1",
                table: "UserRole",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyID",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID1",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyID",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID1",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CompanyID1",
                table: "UserRole",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyID1",
                table: "User",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CompanyID1",
                table: "Roles",
                column: "CompanyID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Company_CompanyID1",
                table: "Roles",
                column: "CompanyID1",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Company_CompanyID1",
                table: "User",
                column: "CompanyID1",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Company_CompanyID1",
                table: "UserRole",
                column: "CompanyID1",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
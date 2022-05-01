using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TestProject.DAL.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Menu_MenuID",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_UserRole_UserRoleID",
                table: "MenuRole");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_MenuID",
                table: "MenuRole");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_UserRoleID",
                table: "MenuRole");

            migrationBuilder.AddColumn<int>(
                name: "MenuID",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolesID",
                table: "MenuRole",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "ID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "Name", "RegistrationNumber", "Type", "UpdDate", "UpdUserID", "UpdUserIP" },
                values: new object[] { 1, new DateTime(2022, 4, 22, 23, 32, 39, 582, DateTimeKind.Local).AddTicks(723), 0, "0", "Seeding-Data", true, "DESKTOP-0000", "INTRANET Yazılım Teknolojileri", "0", "1", new DateTime(2022, 4, 22, 23, 32, 39, 583, DateTimeKind.Local).AddTicks(348), 0, "0" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "MenuID", "Name", "UpdDate", "UpdUserID", "UpdUserIP" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(3991), 0, "0", "TEST", true, "DESKTOP-0000", null, "Yazılım Geliştirici", new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(4000), 0, "0" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "Email", "IsActive", "MachineName", "Password", "Phone", "UpdDate", "UpdUserID", "UpdUserIP", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(8760), 0, "0", "berkcolak4@gmail.com", true, "DESKTOP-0000", "123456", "5434203403", new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(8769), 0, "0", "Berk Çolak" },
                    { 2, 1, new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9871), 0, "0", "test@test.com.tr", true, "DESKTOP-0000", "123456", "123456", new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9878), 0, "0", "Test Test" },
                    { 3, 1, new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9881), 0, "0", "test2@test.com.tr", true, "DESKTOP-0000", "123456", "123456", new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9883), 0, "0", "Test Test" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "ID", "CompanyID", "CrtDate", "CrtUserID", "CrtUserIP", "Desc", "IsActive", "MachineName", "RoleID", "RolesID", "StartDate", "UpdDate", "UpdUserID", "UpdUserIP", "UserID" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(2898), 0, "0", "TEST", true, "DESKTOP-0000", 1, null, new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(3769), new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(2906), 0, "0", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_MenuID",
                table: "Roles",
                column: "MenuID");

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
                name: "FK_Roles_Menu_MenuID",
                table: "Roles",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRole_Roles_RolesID",
                table: "MenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Menu_MenuID",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_MenuID",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_MenuRole_RolesID",
                table: "MenuRole");

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

            migrationBuilder.DropColumn(
                name: "MenuID",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "RolesID",
                table: "MenuRole");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MenuID",
                table: "MenuRole",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_UserRoleID",
                table: "MenuRole",
                column: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_Menu_MenuID",
                table: "MenuRole",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRole_UserRole_UserRoleID",
                table: "MenuRole",
                column: "UserRoleID",
                principalTable: "UserRole",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
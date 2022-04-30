using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.DAL.Migrations
{
    public partial class V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_UserToken", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 982, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 4, 30, 23, 37, 34, 983, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 985, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 4, 30, 23, 37, 34, 985, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(102), new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(1125), new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(1135), new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "StartDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(4946), new DateTime(2022, 4, 30, 23, 37, 34, 986, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_UserID",
                table: "UserToken",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 582, DateTimeKind.Local).AddTicks(723), new DateTime(2022, 4, 22, 23, 32, 39, 583, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(3991), new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9871), new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9881), new DateTime(2022, 4, 22, 23, 32, 39, 584, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "StartDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(3769), new DateTime(2022, 4, 22, 23, 32, 39, 585, DateTimeKind.Local).AddTicks(2906) });
        }
    }
}

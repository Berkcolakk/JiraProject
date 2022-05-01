using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.DAL.Migrations
{
    public partial class V12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParameterMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ParameterMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ParameterDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParameterMasterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ParameterDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParameterDetail_ParameterMaster_ParameterMasterID",
                        column: x => x.ParameterMasterID,
                        principalTable: "ParameterMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 863, DateTimeKind.Local).AddTicks(6586), new DateTime(2022, 5, 1, 19, 32, 43, 864, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 866, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 5, 1, 19, 32, 43, 866, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(505), new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(1569), new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CrtDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CrtDate", "StartDate", "UpdDate" },
                values: new object[] { new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 5, 1, 19, 32, 43, 867, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterDetail_ParameterMasterID",
                table: "ParameterDetail",
                column: "ParameterMasterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParameterDetail");

            migrationBuilder.DropTable(
                name: "ParameterMaster");

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
        }
    }
}

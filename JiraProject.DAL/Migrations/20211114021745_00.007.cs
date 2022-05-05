using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace JiraProject.DAL.Migrations
{
    public partial class _00007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "UserRole",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "UserRole",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "UserRole",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "UserRole",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "UserRole",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "User",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "USER_NAME_SURNAME",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "USER_EMAIL",
                table: "User",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "USER_ACCESSPASSWORD",
                table: "User",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "USER_ACCESSNAME",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "User",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "User",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "User",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "StockMaster",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "StockMaster",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "StockMaster",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "StockMaster",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "StockMaster",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "StockDetail",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "StockDetail",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "StockDetail",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "StockDetail",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "StockDetail",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ProjectManager",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ProjectManager",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ProjectManager",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ProjectManager",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ProjectManager",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ProjectExplore",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ProjectExplore",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ProjectExplore",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ProjectExplore",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ProjectExplore",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "Project",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "Project",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "Project",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "Project",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Project",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "PayoffMaster",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "PayoffMaster",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "PayoffMaster",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "PayoffMaster",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "PayoffMaster",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "PayoffDetail",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "PayoffDetail",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "PayoffDetail",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "PayoffDetail",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "PayoffDetail",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "PayoffDefault",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "PayoffDefault",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "PayoffDefault",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "PayoffDefault",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "PayoffDefault",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "PayoffControl",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "PayoffControl",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "PayoffControl",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "PayoffControl",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "PayoffControl",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ParameterMaster",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ParameterMaster",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ParameterMaster",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ParameterMaster",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ParameterMaster",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ParameterDetail",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ParameterDetail",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ParameterDetail",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ParameterDetail",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ParameterDetail",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "MenuRole",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "MenuRole",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "MenuRole",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "MenuRole",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "MenuRole",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ItemDemandMaster",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ItemDemandMaster",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ItemDemandMaster",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ItemDemandMaster",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ItemDemandMaster",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "ItemDemandDetail",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "ItemDemandDetail",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "ItemDemandDetail",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "ItemDemandDetail",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "ItemDemandDetail",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "Item",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "Item",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "Item",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "Item",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Item",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "Contract",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "Contract",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "Contract",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "Contract",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Contract",
                newName: "UpdDate");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "Company",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "MACHINENAME_MACHINEIDENTITY",
                table: "Company",
                newName: "UpdUserIP");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_IP",
                table: "Company",
                newName: "MachineName");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "Company",
                newName: "UpdUserID");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Company",
                newName: "UpdDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "UserRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "UserRole",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "StockMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "StockMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "StockMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "StockDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "StockDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "StockDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ProjectManager",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ProjectManager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ProjectManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ProjectExplore",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ProjectExplore",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ProjectExplore",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "PayoffMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "PayoffMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "PayoffMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "PayoffDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "PayoffDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "PayoffDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "PayoffDefault",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "PayoffDefault",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "PayoffDefault",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "PayoffControl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "PayoffControl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "PayoffControl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ParameterMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ParameterMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ParameterMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ParameterDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ParameterDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ParameterDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "MenuRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "MenuRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "MenuRole",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ItemDemandMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ItemDemandMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ItemDemandMaster",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "ItemDemandDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "ItemDemandDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "ItemDemandDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "Item",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "Contract",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "Contract",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CrtDate",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CrtUserID",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CrtUserIP",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "StockMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "StockMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "StockMaster");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "StockDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "StockDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "StockDetail");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ProjectManager");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ProjectManager");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ProjectManager");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ProjectExplore");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ProjectExplore");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ProjectExplore");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "PayoffMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "PayoffMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "PayoffMaster");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "PayoffDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "PayoffDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "PayoffDetail");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "PayoffDefault");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "PayoffDefault");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "PayoffDefault");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "PayoffControl");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "PayoffControl");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "PayoffControl");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ParameterMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ParameterMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ParameterMaster");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ParameterDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ParameterDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ParameterDetail");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "MenuRole");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "MenuRole");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "MenuRole");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ItemDemandMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ItemDemandMaster");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ItemDemandMaster");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "ItemDemandDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "ItemDemandDetail");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "ItemDemandDetail");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "CrtDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CrtUserID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CrtUserIP",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "UserRole",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "UserRole",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "UserRole",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "UserRole",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "UserRole",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "User",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "USER_NAME_SURNAME");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "User",
                newName: "USER_EMAIL");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "User",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "User",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "User",
                newName: "USER_ACCESSPASSWORD");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "USER_ACCESSNAME");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "User",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "StockMaster",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "StockMaster",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "StockMaster",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "StockMaster",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "StockMaster",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "StockDetail",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "StockDetail",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "StockDetail",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "StockDetail",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "StockDetail",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ProjectManager",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ProjectManager",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ProjectManager",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ProjectManager",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ProjectManager",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ProjectExplore",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ProjectExplore",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ProjectExplore",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ProjectExplore",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ProjectExplore",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Project",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "Project",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "Project",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "Project",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "Project",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "PayoffMaster",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "PayoffMaster",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "PayoffMaster",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "PayoffMaster",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "PayoffMaster",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "PayoffDetail",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "PayoffDetail",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "PayoffDetail",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "PayoffDetail",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "PayoffDetail",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "PayoffDefault",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "PayoffDefault",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "PayoffDefault",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "PayoffDefault",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "PayoffDefault",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "PayoffControl",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "PayoffControl",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "PayoffControl",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "PayoffControl",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "PayoffControl",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ParameterMaster",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ParameterMaster",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ParameterMaster",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ParameterMaster",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ParameterMaster",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ParameterDetail",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ParameterDetail",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ParameterDetail",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ParameterDetail",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ParameterDetail",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "MenuRole",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "MenuRole",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "MenuRole",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "MenuRole",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "MenuRole",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ItemDemandMaster",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ItemDemandMaster",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ItemDemandMaster",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ItemDemandMaster",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ItemDemandMaster",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ItemDemandDetail",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "ItemDemandDetail",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "ItemDemandDetail",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "ItemDemandDetail",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "ItemDemandDetail",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Item",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "Item",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "Item",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "Item",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "Item",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Contract",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "Contract",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "Contract",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "Contract",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "Contract",
                newName: "CREATED_USER_IP");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Company",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "UpdUserIP",
                table: "Company",
                newName: "MACHINENAME_MACHINEIDENTITY");

            migrationBuilder.RenameColumn(
                name: "UpdUserID",
                table: "Company",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdDate",
                table: "Company",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "MachineName",
                table: "Company",
                newName: "CREATED_USER_IP");
        }
    }
}
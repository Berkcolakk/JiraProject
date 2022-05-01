using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TestProject.DAL.Migrations
{
    public partial class V00001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONTRACT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTRACT_TOTALPRICE = table.Column<double>(type: "float", nullable: false),
                    CONTRACT_PRICECUTRATE = table.Column<double>(type: "float", nullable: false),
                    CONTRACT_MASTER_ID = table.Column<int>(type: "int", nullable: true),
                    CONTRACT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contract_Contract_CONTRACT_MASTER_ID",
                        column: x => x.CONTRACT_MASTER_ID,
                        principalTable: "Contract",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParameterMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARAMETERMASTER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARAMETERMASTER_ISEDITABLE = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ACCESSNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_ACCESSPASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_NAME_SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ParameterDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARAMETERDETAIL_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARAMETERDETAIL_VALUE1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARAMETERDETAIL_VALUE2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARAMETERDETAIL_VALUE3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARAMETERDETAIL_MASTER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParameterDetail_ParameterMaster_PARAMETERDETAIL_MASTER_ID",
                        column: x => x.PARAMETERDETAIL_MASTER_ID,
                        principalTable: "ParameterMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMPANY_TAXNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_TAXNUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_COMPANY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_PHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_FAX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_ADRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPANY_SUBCONTRACTOR = table.Column<bool>(type: "bit", nullable: false),
                    COMPANY_STORE_ID = table.Column<int>(type: "int", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Company_ParameterDetail_COMPANY_STORE_ID",
                        column: x => x.COMPANY_STORE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEM_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_ASSM_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_DEASSM_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_DEASSMDE_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEM_UNIT_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_GROUP_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_REF_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Item_ParameterDetail_ITEM_GROUP_ID",
                        column: x => x.ITEM_GROUP_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_ParameterDetail_ITEM_UNIT_ID",
                        column: x => x.ITEM_UNIT_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MENUROLE_MENU_ID = table.Column<int>(type: "int", nullable: false),
                    MENUROLE_ROLE_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuRole_ParameterDetail_MENUROLE_MENU_ID",
                        column: x => x.MENUROLE_MENU_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuRole_ParameterDetail_MENUROLE_ROLE_ID",
                        column: x => x.MENUROLE_ROLE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERROLE_USER_ID = table.Column<int>(type: "int", nullable: false),
                    USERROLE_ROLE_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRole_ParameterDetail_USERROLE_ROLE_ID",
                        column: x => x.USERROLE_ROLE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_USERROLE_USER_ID",
                        column: x => x.USERROLE_USER_ID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECT_PYP_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECT_GROUP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECT_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECT_EXPLOREDESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECT_DAY = table.Column<int>(type: "int", nullable: false),
                    PROJECT_WORKORDERDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROJECT_DELIVERYDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROJECT_EXPLOREPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECT_OWNERPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECT_CONSTRUCTORPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECT_DISCOUNTEDPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECT_ISDELIVERYEXPLORE = table.Column<bool>(type: "bit", nullable: false),
                    PROJECT_COMPANY_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_CONTRACT_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_STATE_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_EXPLORESTATE_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Project_Company_PROJECT_COMPANY_ID",
                        column: x => x.PROJECT_COMPANY_ID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Contract_PROJECT_CONTRACT_ID",
                        column: x => x.PROJECT_CONTRACT_ID,
                        principalTable: "Contract",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ParameterDetail_PROJECT_EXPLORESTATE_ID",
                        column: x => x.PROJECT_EXPLORESTATE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ParameterDetail_PROJECT_STATE_ID",
                        column: x => x.PROJECT_STATE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ParameterDetail_PROJECT_TYPE_ID",
                        column: x => x.PROJECT_TYPE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STOCKMASTER_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKMASTER_TARGETSTORE_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKMASTER_SOURCESTORE_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKMASTER_COMPANY_ID = table.Column<int>(type: "int", nullable: true),
                    COMPANY_SUB_COMPANY_ID = table.Column<int>(type: "int", nullable: true),
                    STOCKMASTER_WAYBILL_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STOCKMASTER_WAYBILL_DATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STOCKMASTER_REF_ID = table.Column<int>(type: "int", nullable: true),
                    STOCKMASTER_REF_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockMaster_Company_COMPANY_SUB_COMPANY_ID",
                        column: x => x.COMPANY_SUB_COMPANY_ID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMaster_Company_STOCKMASTER_COMPANY_ID",
                        column: x => x.STOCKMASTER_COMPANY_ID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMaster_ParameterDetail_STOCKMASTER_SOURCESTORE_ID",
                        column: x => x.STOCKMASTER_SOURCESTORE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMaster_ParameterDetail_STOCKMASTER_TARGETSTORE_ID",
                        column: x => x.STOCKMASTER_TARGETSTORE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockMaster_ParameterDetail_STOCKMASTER_TYPE_ID",
                        column: x => x.STOCKMASTER_TYPE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayoffDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYOFFDETAIL_ITEMTYPE_ID = table.Column<int>(type: "int", nullable: false),
                    PAYOFFDETAIL_ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    PAYOFFDETAIL_UNITPRICE = table.Column<double>(type: "float", nullable: false),
                    PAYOFFDETAIL_INCLUDEPRICE = table.Column<double>(type: "float", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayoffDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayoffDetail_Item_PAYOFFDETAIL_ITEM_ID",
                        column: x => x.PAYOFFDETAIL_ITEM_ID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PayoffDetail_ParameterDetail_PAYOFFDETAIL_ITEMTYPE_ID",
                        column: x => x.PAYOFFDETAIL_ITEMTYPE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDemandMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEMDEMANDMASTER_PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    ITEMDEMANDMASTER_USER_ID = table.Column<int>(type: "int", nullable: false),
                    ITEMDEMANDMASTER_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITEMDEMANDMASTER_STATE_ID = table.Column<int>(type: "int", nullable: false),
                    ITEMDEMANDMASTER_ITEMCONFIRMATION = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDemandMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemDemandMaster_ParameterDetail_ITEMDEMANDMASTER_STATE_ID",
                        column: x => x.ITEMDEMANDMASTER_STATE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDemandMaster_Project_ITEMDEMANDMASTER_PROJECT_ID",
                        column: x => x.ITEMDEMANDMASTER_PROJECT_ID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDemandMaster_User_ITEMDEMANDMASTER_USER_ID",
                        column: x => x.ITEMDEMANDMASTER_USER_ID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayoffMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYOFFMASTER_PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    PAYOFFMASTER_PARAMETERCODE = table.Column<double>(type: "float", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayoffMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayoffMaster_Project_PAYOFFMASTER_PROJECT_ID",
                        column: x => x.PAYOFFMASTER_PROJECT_ID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectExplore",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTEXPLORE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECTEXPLORE_ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECTEXPLORE_PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECTEXPLORE_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJECTEXPLORE_ITEMQUANTITY = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_ITEMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_ITEMASSMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_ITEMDEASSMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_ITEMDEASSMDEPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_PLACEITEMQUANTITY = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_PLACEITEMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_PLACEITEMASSMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_PLACEITEMDEASSMPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE = table.Column<double>(type: "float", nullable: false),
                    PROJECTEXPLORE_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectExplore", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectExplore_Item_PROJECTEXPLORE_ITEM_ID",
                        column: x => x.PROJECTEXPLORE_ITEM_ID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectExplore_Project_PROJECTEXPLORE_PROJECT_ID",
                        column: x => x.PROJECTEXPLORE_PROJECT_ID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManager",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECTMANAGER_PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECTMANAGER_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManager", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectManager_Project_PROJECTMANAGER_PROJECT_ID",
                        column: x => x.PROJECTMANAGER_PROJECT_ID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManager_User_PROJECTMANAGER_USER_ID",
                        column: x => x.PROJECTMANAGER_USER_ID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STOCKDETAIL_ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKDETAIL_MASTER_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKDETAIL_BARCODE_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STOCKDETAIL_QUANTITY = table.Column<double>(type: "float", nullable: false),
                    STOCKDETAIL_PRIVATEVALUE1 = table.Column<double>(type: "float", nullable: true),
                    STOCKDETAIL_PRIVATEVALUE2 = table.Column<double>(type: "float", nullable: true),
                    STOCKDETAIL_STORE_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKDETAIL_RACK_ID = table.Column<int>(type: "int", nullable: false),
                    STOCKDETAIL_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STOCKDETAIL_SERIALNUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STOCKDETAIL_REF_ID = table.Column<int>(type: "int", nullable: true),
                    STOCKDETAIL_REF_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockDetail_Item_STOCKDETAIL_ITEM_ID",
                        column: x => x.STOCKDETAIL_ITEM_ID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetail_ParameterDetail_STOCKDETAIL_RACK_ID",
                        column: x => x.STOCKDETAIL_RACK_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetail_ParameterDetail_STOCKDETAIL_STORE_ID",
                        column: x => x.STOCKDETAIL_STORE_ID,
                        principalTable: "ParameterDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockDetail_StockMaster_STOCKDETAIL_MASTER_ID",
                        column: x => x.STOCKDETAIL_MASTER_ID,
                        principalTable: "StockMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDemandDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITEMDEMANDDETAIL_MASTER_ID = table.Column<int>(type: "int", nullable: false),
                    ITEMDEMANDDETAIL_ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    ITEMDEMANDDETAIL_QUANTITY = table.Column<double>(type: "float", nullable: false),
                    ITEMDEMANDDETAIL_ITEM_CONFIRMATION = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDemandDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemDemandDetail_Item_ITEMDEMANDDETAIL_ITEM_ID",
                        column: x => x.ITEMDEMANDDETAIL_ITEM_ID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDemandDetail_ItemDemandMaster_ITEMDEMANDDETAIL_MASTER_ID",
                        column: x => x.ITEMDEMANDDETAIL_MASTER_ID,
                        principalTable: "ItemDemandMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayoffControl",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYOFFCONTROL_LB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFCONTROL_PYP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFCONTROL_SAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFCONTROL_ITEMNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFCONTROL_UNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFCONTROL_TENSIZUP = table.Column<double>(type: "float", nullable: false),
                    PAYOFFCONTROL_TENUP = table.Column<double>(type: "float", nullable: false),
                    PAYOFFCONTROL_QUANTITY = table.Column<double>(type: "float", nullable: false),
                    PAYOFFCONTROL_TOTALTENUP = table.Column<double>(type: "float", nullable: false),
                    PAYOFFCONTROL_TOTALTENSIZUP = table.Column<double>(type: "float", nullable: false),
                    PAYOFFCONTROL_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    PAYOFFCONTROL_PAYOFFMASTER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayoffControl", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayoffControl_PayoffMaster_PAYOFFCONTROL_PAYOFFMASTER_ID",
                        column: x => x.PAYOFFCONTROL_PAYOFFMASTER_ID,
                        principalTable: "PayoffMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayoffDefault",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYOFFDEFAULT_DEF1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_DEF20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAYOFFDEFAULT_PAYOFFMASTER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_USER_IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MACHINENAME_MACHINEIDENTITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayoffDefault", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PayoffDefault_PayoffMaster_PAYOFFDEFAULT_PAYOFFMASTER_ID",
                        column: x => x.PAYOFFDEFAULT_PAYOFFMASTER_ID,
                        principalTable: "PayoffMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_COMPANY_STORE_ID",
                table: "Company",
                column: "COMPANY_STORE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CONTRACT_MASTER_ID",
                table: "Contract",
                column: "CONTRACT_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ITEM_GROUP_ID",
                table: "Item",
                column: "ITEM_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ITEM_UNIT_ID",
                table: "Item",
                column: "ITEM_UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDemandDetail_ITEMDEMANDDETAIL_ITEM_ID",
                table: "ItemDemandDetail",
                column: "ITEMDEMANDDETAIL_ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDemandDetail_ITEMDEMANDDETAIL_MASTER_ID",
                table: "ItemDemandDetail",
                column: "ITEMDEMANDDETAIL_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDemandMaster_ITEMDEMANDMASTER_PROJECT_ID",
                table: "ItemDemandMaster",
                column: "ITEMDEMANDMASTER_PROJECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDemandMaster_ITEMDEMANDMASTER_STATE_ID",
                table: "ItemDemandMaster",
                column: "ITEMDEMANDMASTER_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDemandMaster_ITEMDEMANDMASTER_USER_ID",
                table: "ItemDemandMaster",
                column: "ITEMDEMANDMASTER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MENUROLE_MENU_ID",
                table: "MenuRole",
                column: "MENUROLE_MENU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_MENUROLE_ROLE_ID",
                table: "MenuRole",
                column: "MENUROLE_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterDetail_PARAMETERDETAIL_MASTER_ID",
                table: "ParameterDetail",
                column: "PARAMETERDETAIL_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PayoffControl_PAYOFFCONTROL_PAYOFFMASTER_ID",
                table: "PayoffControl",
                column: "PAYOFFCONTROL_PAYOFFMASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PayoffDefault_PAYOFFDEFAULT_PAYOFFMASTER_ID",
                table: "PayoffDefault",
                column: "PAYOFFDEFAULT_PAYOFFMASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PayoffDetail_PAYOFFDETAIL_ITEM_ID",
                table: "PayoffDetail",
                column: "PAYOFFDETAIL_ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PayoffDetail_PAYOFFDETAIL_ITEMTYPE_ID",
                table: "PayoffDetail",
                column: "PAYOFFDETAIL_ITEMTYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PayoffMaster_PAYOFFMASTER_PROJECT_ID",
                table: "PayoffMaster",
                column: "PAYOFFMASTER_PROJECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PROJECT_COMPANY_ID",
                table: "Project",
                column: "PROJECT_COMPANY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PROJECT_CONTRACT_ID",
                table: "Project",
                column: "PROJECT_CONTRACT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PROJECT_EXPLORESTATE_ID",
                table: "Project",
                column: "PROJECT_EXPLORESTATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PROJECT_STATE_ID",
                table: "Project",
                column: "PROJECT_STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PROJECT_TYPE_ID",
                table: "Project",
                column: "PROJECT_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExplore_PROJECTEXPLORE_ITEM_ID",
                table: "ProjectExplore",
                column: "PROJECTEXPLORE_ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExplore_PROJECTEXPLORE_PROJECT_ID",
                table: "ProjectExplore",
                column: "PROJECTEXPLORE_PROJECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManager_PROJECTMANAGER_PROJECT_ID",
                table: "ProjectManager",
                column: "PROJECTMANAGER_PROJECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManager_PROJECTMANAGER_USER_ID",
                table: "ProjectManager",
                column: "PROJECTMANAGER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetail_STOCKDETAIL_ITEM_ID",
                table: "StockDetail",
                column: "STOCKDETAIL_ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetail_STOCKDETAIL_MASTER_ID",
                table: "StockDetail",
                column: "STOCKDETAIL_MASTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetail_STOCKDETAIL_RACK_ID",
                table: "StockDetail",
                column: "STOCKDETAIL_RACK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockDetail_STOCKDETAIL_STORE_ID",
                table: "StockDetail",
                column: "STOCKDETAIL_STORE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMaster_COMPANY_SUB_COMPANY_ID",
                table: "StockMaster",
                column: "COMPANY_SUB_COMPANY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMaster_STOCKMASTER_COMPANY_ID",
                table: "StockMaster",
                column: "STOCKMASTER_COMPANY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMaster_STOCKMASTER_SOURCESTORE_ID",
                table: "StockMaster",
                column: "STOCKMASTER_SOURCESTORE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMaster_STOCKMASTER_TARGETSTORE_ID",
                table: "StockMaster",
                column: "STOCKMASTER_TARGETSTORE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StockMaster_STOCKMASTER_TYPE_ID",
                table: "StockMaster",
                column: "STOCKMASTER_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_USERROLE_ROLE_ID",
                table: "UserRole",
                column: "USERROLE_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_USERROLE_USER_ID",
                table: "UserRole",
                column: "USERROLE_USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDemandDetail");

            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "PayoffControl");

            migrationBuilder.DropTable(
                name: "PayoffDefault");

            migrationBuilder.DropTable(
                name: "PayoffDetail");

            migrationBuilder.DropTable(
                name: "ProjectExplore");

            migrationBuilder.DropTable(
                name: "ProjectManager");

            migrationBuilder.DropTable(
                name: "StockDetail");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "ItemDemandMaster");

            migrationBuilder.DropTable(
                name: "PayoffMaster");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "StockMaster");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "ParameterDetail");

            migrationBuilder.DropTable(
                name: "ParameterMaster");
        }
    }
}
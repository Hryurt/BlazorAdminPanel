using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoyalstarAdminPanel.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceBarcodeNo = table.Column<int>(type: "int", nullable: false),
                    DeviceOnOff = table.Column<bool>(type: "bit", nullable: false),
                    ActivePower = table.Column<int>(type: "int", nullable: false),
                    ApparentPower = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceBarcodeNo = table.Column<int>(type: "int", nullable: false),
                    MainsActivePower = table.Column<int>(type: "int", nullable: false),
                    MainsApparentPower = table.Column<int>(type: "int", nullable: false),
                    MainsCurrent = table.Column<int>(type: "int", nullable: false),
                    MainsDeviceOnOff = table.Column<bool>(type: "bit", nullable: false),
                    MainsFrequence = table.Column<int>(type: "int", nullable: false),
                    MainsBreakerOff = table.Column<bool>(type: "bit", nullable: false),
                    MainsBreakerOn = table.Column<bool>(type: "bit", nullable: false),
                    MainsModeManuel = table.Column<bool>(type: "bit", nullable: false),
                    MainsModeSemi = table.Column<bool>(type: "bit", nullable: false),
                    MainsStatusOff = table.Column<bool>(type: "bit", nullable: false),
                    MainsStatusOn = table.Column<bool>(type: "bit", nullable: false),
                    MainsReactivePower = table.Column<int>(type: "int", nullable: false),
                    MainsVolt = table.Column<int>(type: "int", nullable: false),
                    WriteCommand = table.Column<bool>(type: "bit", nullable: false),
                    deviceAdded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMachines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "MainMachines");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

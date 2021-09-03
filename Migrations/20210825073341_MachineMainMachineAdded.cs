using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoyalstarAdminPanel.Migrations
{
    public partial class MachineMainMachineAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceBarcodeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    DeviceOnOff = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActivePower = table.Column<int>(type: "INTEGER", nullable: false),
                    ApparentPower = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeviceBarcodeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsActivePower = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsApparentPower = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsCurrent = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsDeviceOnOff = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsFrequence = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsBreakerOff = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsBreakerOn = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsModeManuel = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsModeSemi = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsStatusOff = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsStatusOn = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainsReactivePower = table.Column<int>(type: "INTEGER", nullable: false),
                    MainsVolt = table.Column<int>(type: "INTEGER", nullable: false),
                    WriteCommand = table.Column<bool>(type: "INTEGER", nullable: false),
                    deviceAdded = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMachines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "MainMachines");
        }
    }
}
